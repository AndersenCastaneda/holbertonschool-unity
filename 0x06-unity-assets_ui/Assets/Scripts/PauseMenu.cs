#pragma warning disable 0649
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseCanvas;
    [SerializeField] private SceneState sceneState;
    private bool _isActive;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Pause();
    }

    private void Pause()
    {
        _isActive = !_isActive;
        Time.timeScale = _isActive ? 0f : 1f;
        pauseCanvas.SetActive(_isActive);
    }

    public void Resume()
    {
        _isActive = !_isActive;
        Time.timeScale = _isActive ? 0f : 1f;
        pauseCanvas.SetActive(_isActive);
    }

    public void Restart()
    {
        var level = SceneManager.GetActiveScene().name;
        Time.timeScale = 1f;
        SceneManager.LoadScene(level);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void Options()
    {
        sceneState.previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Options");
    }
}
