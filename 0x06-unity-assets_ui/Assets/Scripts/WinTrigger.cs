#pragma warning disable 0649
using System;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public static Action OnWin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            OnWin?.Invoke();
    }
}
