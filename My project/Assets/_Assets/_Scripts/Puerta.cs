using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private GameObject PanelVictoria;  // un panel UI que mostraremos al ganar

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameManager.TieneLlave())
            {
                Debug.Log("¡GANASTE!");

                if (PanelVictoria != null)
                {
                    PanelVictoria.SetActive(true);
                }

                // Pausar el juego
                Time.timeScale = 0f;
            }
            
        }
        else
        {
            Debug.Log("La puerta está cerrada, necesitas la llave.");
        }
    }

}
