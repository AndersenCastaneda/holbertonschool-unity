#pragma warning disable 0649

using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }
    [SerializeField] private Joystick joystick;

    public void ReadInput()
    {
#if UNITY_IOS || UNITY_ANDROID
        Horizontal = joystick.Horizontal;
        Vertical = joystick.Vertical;
#endif
#if UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN ||UNITY_STANDALONE_LINUX
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
#endif
    }
}
