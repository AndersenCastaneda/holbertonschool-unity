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

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate() => CamControl();

    //Rotate Around
    private void CamControl()
    {
        if (Input.GetMouseButton(1))
        {
            mouseX += inputX.value * rotationSpeed;
            mouseY -= inputY.value * rotationSpeed;
            mouseY = Mathf.Clamp(mouseY, minX, maxX);
            transform.LookAt(target);
            target.rotation = Quaternion.Euler(mouseY, mouseX, 0f);
        }
    }
}
