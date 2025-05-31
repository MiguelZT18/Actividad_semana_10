using UnityEngine;

public class PanelGameOver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
