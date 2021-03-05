#pragma warning disable 0649
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameObject timerCanvas;
    [SerializeField] private GameObject mainCamera;

    public void OnFinishedIntro()
    {
        mainCamera.SetActive(true);
        timerCanvas.SetActive(true);
        playerController.enabled = true;
        enabled = false;
        gameObject.SetActive(false);
    }
}
