using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    private float speed = 5f;

    private Vector2 moveDireciton = Vector2.zero;

    [SerializeField]
    InputAction PlayerMovement;

    private void OnEnable()
    {
        PlayerMovement.Enable();
    }

    private void OnDisable()
    {
        PlayerMovement.Disable();
    }

    void Update()
    {
        moveDireciton = PlayerMovement.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDireciton.x * speed, moveDireciton.y * speed);
    }
}
