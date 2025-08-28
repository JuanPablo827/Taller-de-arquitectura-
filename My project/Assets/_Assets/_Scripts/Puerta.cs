using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameManager.TieneLlave())
            {
                Debug.Log("🎉 ¡Nivel completado!");
                // Aquí puedes cargar la siguiente escena
                // SceneManager.LoadScene("SiguienteNivel");
            }
            else
            {
                Debug.Log("🚪 La puerta está cerrada, necesitas la llave.");
            }
        }
    }

}
