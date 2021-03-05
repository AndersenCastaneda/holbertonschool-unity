#pragma warning disable 0649
using UnityEngine;

public class InputController : MonoBehaviour
{
    [Header("Input Reference")]
    [SerializeField] private Float horizontal;
    [SerializeField] private Float vertical;
    [SerializeField] private Float mouseX;
    [SerializeField] private Float mouseY;

    private void Update()
    {
        horizontal.value = Input.GetAxisRaw("Horizontal");
        vertical.value = Input.GetAxisRaw("Vertical");
        mouseX.value = Input.GetAxis("Mouse X");
        mouseY.value = Input.GetAxis("Mouse Y");
    }
}
