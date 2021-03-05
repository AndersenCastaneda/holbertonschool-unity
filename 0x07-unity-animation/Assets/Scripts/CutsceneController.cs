#pragma warning disable 0649
using System.Collections;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameObject timerCanvas;
    [SerializeField] private GameObject camera;

    public void OnFinishedIntro()
    {
        camera.SetActive(true);
        timerCanvas.SetActive(true);
        playerController.enabled = true;
        enabled = false;
        gameObject.SetActive(false);
    }
}
