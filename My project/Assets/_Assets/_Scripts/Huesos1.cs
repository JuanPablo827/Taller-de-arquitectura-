using UnityEngine;

public class Huesos1 : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.SumarPuntos(1); // cada hueso suma 1 punto
            Destroy(gameObject); // se elimina al recogerlo
        }
    }

}
