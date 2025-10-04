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
        for(int i = 0; i < 4; i++)
        {
            spriteCorazon[i].enabled = true;
        }

        spriteCorazon[0].enabled = false;

        gameObjectCorazon[0].SetActive(true);
        gameObjectCorazon[1].SetActive(false);
        gameObjectCorazon[2].SetActive(false);
        gameObjectCorazon[3].SetActive(false);
        gameObjectCorazon[4].SetActive(false);







    }

        



    }

