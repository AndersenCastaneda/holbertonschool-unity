#pragma warning disable 0649
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private SceneState sceneState;

    public void LevelSelect(int level) => SceneManager.LoadScene(level);

    public void Options()
    {
        sceneState.previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Options");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
