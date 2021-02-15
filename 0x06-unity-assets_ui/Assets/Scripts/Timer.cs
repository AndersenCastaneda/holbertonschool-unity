using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    private float timer = 0.00f;

    private void OnEnable() => WinTrigger.OnWin += Inactive;
    private void OnDisable() => WinTrigger.OnWin -= Inactive;

    void Update() => IncrementTimer();

    private void IncrementTimer()
    {
        timer += Time.deltaTime;
        TimerText.text = string.Format("{1:0}:{0:00.00}", timer % 60, timer / 60).Replace(",", ".");
    }

    private void Inactive()
    {
        TimerText.color = Color.green;
        TimerText.fontSize = 60;
        enabled = false;
    }
}
