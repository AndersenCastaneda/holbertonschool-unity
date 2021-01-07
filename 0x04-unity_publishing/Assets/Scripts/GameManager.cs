#pragma warning disable 0649

using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Buttons;

    void Start()
    {
#if UNITY_IOS || UNITY_ANDROID
        Buttons.SetActive(true);
#endif
    }
}
