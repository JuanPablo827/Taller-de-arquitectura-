using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int vidas = 5;          // Vidas iniciales
    public int puntos = 0;         // Puntos iniciales
    public float tiempo = 120f;     // Tiempo en segundos (ej: 1 minuto)

    // ESTA ES LA VARIABLE CLAVE
    private bool tieneLlave = false; // Estado de la llave (empieza en "No")

    [SerializeField] private GameObject panelMenu;  // Panel del menú de pausa
    private bool juegoPausado = false;




    [SerializeField]
    private TMP_Text textoTiempo;
  

    [SerializeField] private TMP_Text[] nombres;
    [SerializeField] UIManager uiManager;

    [SerializeField] private GameObject Llave;








    void Start()
    {
        if (Llave != null)
        {
            Llave.SetActive(false); //llave
        }


        uiManager.ActualizarHuesos(puntos);
        ActualizarUI("tiempo");
        uiManager.ActualizarCorazones(vidas);
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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                ReanudarJuego();
            }
            else
            {
                PausarJuego();
            }
        }




    }

    // -------- MÉTODOS PÚBLICOS --------
    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        ActualizarUI("puntos");
        uiManager.ActualizarHuesos(puntos);
    }

    public void RestarVidas(int cantidad)
    {
        vidas -= cantidad;
        ActualizarUI("vidas");
        uiManager.ActualizarCorazones(vidas);

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
        if (Llave != null)
        {
            Llave.SetActive(true);
        }
    }

    public bool TieneLlave()
    {
        return tieneLlave;
    }

    public void PausarJuego()
    {
        panelMenu.SetActive(true);
        Time.timeScale = 0f;
        juegoPausado = true;
    }

    public void ReanudarJuego()
    {
        panelMenu.SetActive(false);
        Time.timeScale = 1f;
        juegoPausado = false;
    }











    // -------- ACTUALIZAR INTERFAZ --------
    private void ActualizarUI(string texto)
    {
        switch (texto)
        {

            case "tiempo":
                textoTiempo.text = "Tiempo: " + Mathf.Ceil(tiempo);
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
                SceneManager.LoadScene(2);
                break;
            case "Perdiste":
                //cargar la escena del juego 
                //LoadScene();s
                SceneManager.LoadScene(3);
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
            case "Salir":
                Application.Quit();
                break;
        }
    }
}