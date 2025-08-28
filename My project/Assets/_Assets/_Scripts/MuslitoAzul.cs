using UnityEngine;

public class MuslitoAzul : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private float tiempoExtra = 10f; // segundos que da

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.tiempo += tiempoExtra;
            Destroy(gameObject);
        }
    }
}
