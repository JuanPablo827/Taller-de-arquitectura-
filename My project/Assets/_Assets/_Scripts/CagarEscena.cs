using UnityEngine;
using UnityEngine.SceneManagement;
public class CagarEscena : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    public void OpenScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

}
