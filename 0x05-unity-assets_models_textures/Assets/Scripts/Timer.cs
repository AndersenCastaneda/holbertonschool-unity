using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    private float startTime;
    int minutes;
    float seconds;

    private void OnEnable() => WinTrigger.OnWin += Inactive;
    private void OnDisable() => WinTrigger.OnWin -= Inactive;

    private void Start() => startTime = Time.time;

    void Update()
    {
        float t = Time.time - startTime;
        minutes = ((int)t / 60);
        seconds = (t % 60);

        if (seconds < 10f)
            TimerText.text = $"{minutes}:0{seconds.ToString("f2").Replace(",", ".")}";
        else
            TimerText.text = $"{minutes}:{seconds.ToString("f2").Replace(",", ".")}";
    }

    private void Inactive()
    {
        TimerText.color = Color.green;
        TimerText.fontSize = 60;
        enabled = false;
    }
}
