using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 10f;
    public bool isOnGround = true;

    private void Awake() => rb = gameObject.GetComponent<Rigidbody>();

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
            isOnGround = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }

    private void FixedUpdate() => Perform();

    private void Perform()
    {
        if (isOnGround)
            rb.MovePosition(rb.position + (new Vector3(InputManager.horizontal, 0, InputManager.vertical) * moveSpeed * Time.fixedDeltaTime));
    }

    private void Jump()
    {
        if (isOnGround)
        {
            isOnGround = false;
            rb.AddForce(new Vector3(InputManager.horizontal, 5, InputManager.vertical), ForceMode.Impulse);
        }
    }

    private void StopMovement()
    {
        rb.drag = 2;
        this.enabled = false;
    }
}
