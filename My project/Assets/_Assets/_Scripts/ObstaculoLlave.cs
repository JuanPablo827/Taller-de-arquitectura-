using UnityEngine;

public class ObstaculoLlave : MonoBehaviour
{
    [SerializeField] 
    private GameManager gameManager;
    [SerializeField] 
    private int puntosNecesarios = 10; // ejemplo: 5 huesos

    void Update()
    {
        if (gameManager.puntos >= puntosNecesarios)
        {
            Destroy(gameObject); // se destruye el obst�culo y libera la llave
        }
    }
}
