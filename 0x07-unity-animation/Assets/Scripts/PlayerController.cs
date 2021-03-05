#pragma warning disable 0649
using UnityEngine;

/// <summary>
/// PlayerController - Handle Player Movement and Jump
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Float horizontal, vertical;

    private CharacterController controller;
    private Vector3 direction;
    [SerializeField] private Transform cam;

    [SerializeField] private Animator animator;

    private readonly float jumpSpeed = 2.7f;
    private readonly float gravity = 9.81f;
    private readonly float moveSpeed = 15f;

    private float directionY;
    private bool isJumping;

    private void Awake()
    {
        if (controller == null)
            controller = GetComponent<CharacterController>();
    }

    private void Update() => Movement();

    private void Movement()
    {
        if (vertical.value > 0)
        {
            animator.SetBool("MoveBackward", false);
            animator.SetBool("MoveForward", true);
        }
        else if (vertical.value < 0)
        {
            animator.SetBool("MoveForward", false);
            animator.SetBool("MoveBackward", true);
        }
        else
        {
            animator.SetBool("MoveForward", false);
            animator.SetBool("MoveBackward", false);
        }

        if (controller.isGrounded)
        {
            direction = Vector3.Normalize((vertical.value * cam.forward) + (horizontal.value * cam.right));
            if (isJumping)
            {
                isJumping = false;
                animator.SetBool("IsJumping", isJumping);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                directionY = jumpSpeed;
                isJumping = true;
                animator.SetBool("IsJumping", isJumping);
            }
        }

        directionY -= gravity * Time.deltaTime;
        direction.y = directionY;

        if (direction.magnitude >= 0.1f)
            controller.Move(direction * (moveSpeed * Time.deltaTime));

        if (transform.position.y < -50f)
            transform.position = new Vector3(0f, 20f, 0f);
    }
}
