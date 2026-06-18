using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public InputAction playerControls;
    public Rigidbody2D playerPhysics;
    public float playerSpeed = 5f;
    public InputAction PlayerJump;
    public float playerJumpForce;
    public static int playerCoins;
    Vector2 playerDirection;
    private void OnEnable()
    {
        
        playerControls.Enable();
        PlayerJump.Enable();
        PlayerJump.performed += DoJump;

    }
    private void OnDisable()
    {
        
        playerControls.Disable();
        PlayerJump.Disable();
    }
    void Update()
    {
        playerDirection = playerControls.ReadValue<Vector2>();
        playerPhysics.linearVelocity = new Vector2(playerDirection.x * playerSpeed , playerPhysics.linearVelocity.y);
    }

    public void DoJump(InputAction.CallbackContext context)
    {
        
         playerPhysics.linearVelocity = new Vector2(playerPhysics.linearVelocity.x, playerJumpForce);

    }

    

}
