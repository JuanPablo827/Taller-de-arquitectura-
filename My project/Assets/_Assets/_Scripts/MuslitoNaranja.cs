using UnityEngine;

public class MuslitoNaranja : MonoBehaviour
{
    [SerializeField] 
    private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.RestarVidas(-1); // -1 resta negativo → suma 1 vida
            Destroy(gameObject);
        }
    }
}
