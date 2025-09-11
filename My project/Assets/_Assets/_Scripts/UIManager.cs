using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textoIntroduccion;
    [SerializeField]
    private TMP_InputField inputField;

    private int edad;
    //si mi jugador es menor de 12 anos es un nino 
    // si mi jugador es mayor de 12 anos pero menor a 18 es un adolescente 
    // si mi jugador es mayor a 18 pero menor a 25 anos es un adulto joven 
    // si mi jugador es mayor a 25 anos y menor a 60 es un adulto 
    // si mi jugador es mayor a 60 anos es un adulto mayor 


    private void Start()
    {
        textoIntroduccion.text = "Introduce tu edad";
    }

    public void CalcularGrupo()
    {
        edad = int.Parse(inputField.text);
        switch (edad)
        {
            case 18:

                print("Tiene 18 anos");
                break;

                case 25:
                print("Tiene 25 anos");
                break;

            case 40:
                print("Tiene 40 anos");
                break;
            default:

                
                print("Tiene otra edad");
                break;
        }
        


        
        if(edad <= 12)
        {
            Debug.Log("eres un nino");
        }
        else if (edad > 12 && edad <= 18)
        {
            Debug.Log("eres un adolescente");
        }
        else if (edad > 18 && edad <= 25)
        {
            Debug.Log("eres un adulto joven");
        }
        else if (edad > 25 && edad <= 60)
        {
            Debug.Log("eres un adulto");
        }
        else if (edad > 60 )
        {
            Debug.Log("eres un adulto mayor");
        }

        
        

    }

}

