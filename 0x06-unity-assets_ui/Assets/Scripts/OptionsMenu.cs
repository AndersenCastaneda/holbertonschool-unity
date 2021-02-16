#pragma warning disable 0649
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private SceneState sceneState;

    public void Back() => SceneManager.LoadScene(sceneState.previousScene);
}
