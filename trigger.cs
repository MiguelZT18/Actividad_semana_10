using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public GameObject panelUI; // Asigna el panel desde el Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            panelUI.SetActive(true); // Muestra el panel
        }
    }
      private void OnTriggerExit2D(Collider2D collision)
{
    if (collision.CompareTag("Player"))
    {
        panelUI.SetActive(false); // Oculta el panel
    }
}
  
}

