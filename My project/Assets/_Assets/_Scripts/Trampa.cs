using UnityEngine;

public class Trampa : MonoBehaviour
{
    [SerializeField] 
    private GameManager gameManager;
    [SerializeField] 
    private int dano = 1; // cuántas vidas quita

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.RestarVidas(dano);
            Debug.Log("⚠️ El jugador tocó una trampa y perdió " + dano + " vida(s).");
        }
    }
}
