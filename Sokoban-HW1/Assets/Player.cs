using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public InputActionReference move;
    public GameManager gameManager;

    private Rigidbody playerRigidbody;
    private Vector2 movementInput;
    private float speed = 10f;

    void Start()
    {
        if (!playerRigidbody)
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        movementInput = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        if (gameManager.isGameOver)
        {
            return;
        }

        Vector3 velocity = new Vector3(movementInput.x, 0f, movementInput.y) * speed;
        playerRigidbody.linearVelocity = velocity;
    }
}
