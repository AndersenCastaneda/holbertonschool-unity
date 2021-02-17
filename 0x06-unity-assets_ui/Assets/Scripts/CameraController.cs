#pragma warning disable 0649
using UnityEngine;

/// <summary>
/// CameraController - Rotate around Player
/// </summary>
public class CameraController : MonoBehaviour
{
    [SerializeField] Float inputX, inputY;
    [SerializeField] private Transform target;
    private float mouseX, mouseY;
    private readonly float rotationSpeed = 1f;
    private readonly float minX = -20f;
    private readonly float maxX = 60f;
    [SerializeField] private ViewYState viewYState;
    public bool isInverted;

    private void Start()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
        transform.SetParent(target);
        isInverted = viewYState.isInverted;
    }

    private void LateUpdate() => CamControl();

    //Rotate Around
    private void CamControl()
    {
        if (Input.GetMouseButton(1))
        {
            var invert = isInverted ? 1f : -1f;
            mouseX += inputX.value * rotationSpeed;
            mouseY -= inputY.value * rotationSpeed * invert;
            mouseY = Mathf.Clamp(mouseY, minX, maxX);
            transform.LookAt(target);
            target.rotation = Quaternion.Euler(mouseY, mouseX, 0f);
        }
    }
}
