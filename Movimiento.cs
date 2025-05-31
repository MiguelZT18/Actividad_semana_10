using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 movement;
    Vector2 lastMoveDir;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement != Vector2.zero)
        {
            lastMoveDir = movement;
        }

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    
    if (movement.x > 0) // derecha
    {
    transform.localScale = new Vector3(1, 1, 1); // normal
    }
    else if (movement.x < 0) // izquierda
    {   
    transform.localScale = new Vector3(-1, 1, 1); // volteado
    }


}
    void FixedUpdate()
    {
        // Movimiento del personaje
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
