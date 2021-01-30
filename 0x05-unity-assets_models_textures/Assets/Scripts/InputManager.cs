using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static float vertical;
    public static float horizontal;

    private void Update() => GetInput();

    private void GetInput()
    {
        vertical = Input.GetAxis("Vertical");       // W y S ó ↑ y ↓
        horizontal = Input.GetAxis("Horizontal");   // A y D ó ← y →
    }
}
