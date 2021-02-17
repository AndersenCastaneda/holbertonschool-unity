#pragma warning disable 0649
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private SceneState sceneState;
    [SerializeField] private Toggle toggle;
    [SerializeField] private ViewYState viewYState;

    private void Start() => toggle.isOn = viewYState.isInverted;

    public void Back() => SceneManager.LoadScene(sceneState.previousScene);

    public void Apply()
    {
        viewYState.isInverted = toggle.isOn;
        SceneManager.LoadScene(sceneState.previousScene);
    }
}
