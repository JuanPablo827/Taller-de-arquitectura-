using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
      

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameManager.TieneLlave())
            {
                Debug.Log("¡GANASTE!");
                gameManager.EstadoDeJuego("Ganaste"); 
            }
            else
            {
                Debug.Log("La puerta está cerrada, necesitas la llave.");
            }
        }
    }
}