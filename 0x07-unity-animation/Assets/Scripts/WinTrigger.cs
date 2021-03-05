#pragma warning disable 0649
using System;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] private GameObject winCanvas;
    [SerializeField] private GameObject timerCanvas;
    public static Action OnWin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnWin?.Invoke();
            timerCanvas.SetActive(false);
            winCanvas.SetActive(true);
        }
    }
}
