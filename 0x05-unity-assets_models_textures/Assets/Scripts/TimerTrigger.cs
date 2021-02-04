#pragma warning disable 0649
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    [SerializeField] private Timer timer;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            timer.enabled = true;
    }
}
