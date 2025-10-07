using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Video;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] gameObjectCorazon;
    [SerializeField]
    private Image[] spriteCorazon;

    public void ActualizarCorazones(int vidas)
    {
        for (int i = 0; i < spriteCorazon.Length; i++)
        {
            bool corazonActivo = i < vidas;
            gameObjectCorazon[i].SetActive(corazonActivo);
            spriteCorazon[i].enabled = corazonActivo;
        }
    }

    [Header("Huesos UI")]
    [SerializeField] private GameObject[] gameObjectHuesos;  // contenedores de cada ícono
    [SerializeField] private Image[] spriteHuesos;           // imágenes de cada hueso

    public void ActualizarHuesos(int cantidad)
    {
        for (int i = 0; i < spriteHuesos.Length; i++)
        {
            bool huesoActivo = i < cantidad;
            gameObjectHuesos[i].SetActive(huesoActivo);
            spriteHuesos[i].enabled = huesoActivo;
        }
    }
}