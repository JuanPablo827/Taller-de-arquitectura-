using UnityEngine;

public class Llave : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.ObtenerLlave();
            Destroy(gameObject);
        }
    }
}
