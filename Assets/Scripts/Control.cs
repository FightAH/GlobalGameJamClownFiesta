using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("LevelLayout");
    }
    public void Quit()
    {
        Application.Quit();
    }
    
}