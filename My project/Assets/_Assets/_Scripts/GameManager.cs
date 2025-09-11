using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
        ActualizarUI("vidas");
        ActualizarUI("puntos");
        ActualizarUI("tiempo");
        ActualizarUI("llave");
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
                EstadoDeJuego("Perdiste");
            }

            ActualizarUI("tiempo");
        }
    }

    // -------- MÉTODOS PÚBLICOS --------
    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        ActualizarUI("puntos");
    }

    public void RestarVidas(int cantidad)
    {
        vidas -= cantidad;
        ActualizarUI("vidas");

        if (vidas <= 0)
        {
            Debug.Log("Game Over");
            EstadoDeJuego("Perdiste");
        }
    }

    public void ObtenerLlave()
    {
        // AQUÍ se cambia a true cuando el jugador la recoge
        tieneLlave = true;
        ActualizarUI("llave");
    }

    public bool TieneLlave()
    {
        return tieneLlave;
    }

    // -------- ACTUALIZAR INTERFAZ --------
    private void ActualizarUI(string texto)
    {
        switch (texto)
        {
            case "vidas":
            textoVidas.text = "Vidas: " + vidas;
                break;
            case "puntos":
                textoPuntos.text = "Puntos: " + puntos;
                break;
            case "tiempo":
                textoTiempo.text = "Tiempo: " + Mathf.Ceil(tiempo);
                break;
            case "llave":
                textoLlave.text = "Llave: " + (tieneLlave ? "Sí" : "No");
                break;
                default:

                break;
        }
    }

    public void EstadoDeJuego(string estado)
    {
        switch (estado) 
        {
            case "Ganaste":
                //cargar la escena de victoria, la cual tiene un texto que diga ganaste
                //LoadScene();
                SceneManager.LoadScene("Ganaste");
                break;
            case "Perdiste":
                //cargar la escena del juego 
                //LoadScene();
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
            case "Pausa":
                //tenemos un boton en la ui al darle click pausa el juego
                //Time.timescale = 0;
                Time.timeScale = 0f;
                break;
            case "Jugando":
                //tenemos un boton que al darle click continua el juego 
                //Time.timeScale = 1;
                Time.timeScale = 1f;
                break;
        }
    }
}