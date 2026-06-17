using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public InputAction playerControls;
    public Rigidbody2D playerPhysics;
    public float playerSpeed = 5f;
    Vector2 playerDirection;
    private void OnEnable()
    {
        
        playerControls.Enable();

    }
    private void OnDisable()
    {
        
        playerControls.Disable();

    }
    void Update()
    {
        playerDirection = playerControls.ReadValue<Vector2>();
        playerPhysics.linearVelocity = new Vector2(playerDirection.x * playerSpeed , playerPhysics.linearVelocity.y);
    }
}
