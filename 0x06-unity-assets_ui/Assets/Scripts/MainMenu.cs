using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LevelSelect(int level) => SceneManager.LoadScene(level);

    public void Options() => SceneManager.LoadScene("Options");

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
