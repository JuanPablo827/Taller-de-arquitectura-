using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public int vidas = 3;          // Vidas iniciales
    public int puntos = 0;         // Puntos iniciales
    public float tiempo = 120f;     // Tiempo en segundos (ej: 1 minuto)

    // ESTA ES LA VARIABLE CLAVE
    private bool tieneLlave = false; // Estado de la llave (empieza en "No")

    
    [SerializeField] 
    private TMP_Text textoVidas;
    [SerializeField] 
    private TMP_Text textoPuntos;
    [SerializeField] 
    private TMP_Text textoTiempo;
    [SerializeField] 
    private TMP_Text textoLlave;

    void Start()
    {
        ActualizarUI();
    }

    void Update()
    {
        // Contador de tiempo
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;

            if (tiempo <= 0)
            {
                tiempo = 0;
                Debug.Log("Tiempo agotado → Game Over");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            ActualizarUI();
        }
    }

    // -------- MÉTODOS PÚBLICOS --------
    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        ActualizarUI();
    }

    public void RestarVidas(int cantidad)
    {
        vidas -= cantidad;
        ActualizarUI();

        if (vidas <= 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void ObtenerLlave()
    {
        // AQUÍ se cambia a true cuando el jugador la recoge
        tieneLlave = true;
        ActualizarUI();
    }

    public bool TieneLlave()
    {
        return tieneLlave;
    }

    // -------- ACTUALIZAR INTERFAZ --------
    private void ActualizarUI()
    {
        if (textoVidas != null) textoVidas.text = "Vidas: " + vidas;
        if (textoPuntos != null) textoPuntos.text = "Puntos: " + puntos;
        if (textoTiempo != null) textoTiempo.text = "Tiempo: " + Mathf.Ceil(tiempo);
        if (textoLlave != null) textoLlave.text = "Llave: " + (tieneLlave ? "Sí" : "No");
    }
}