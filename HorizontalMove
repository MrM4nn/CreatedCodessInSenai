using UnityEngine;

public class Movimento : MonoBehaviour
{


    private Rigidbody2D physicsPlayer;

    private SpriteRenderer spritePlayer;

    private float horizontalInput;

    public float moveSpeed = 5f;


   
    void Start()
    {

       physicsPlayer = GetComponent<Rigidbody2D>();
       spritePlayer = GetComponent<SpriteRenderer>();

    }

    
    void Update()
    {
        //armazena na variavel os inputs horizontais (apertadas esquerda e direita(a e d))
        horizontalInput = Input.GetAxis("Horizontal");

        physicsPlayer.linearVelocity = new Vector2(horizontalInput * moveSpeed, physicsPlayer.linearVelocity.y);

        if (horizontalInput > 0)
        {
            spritePlayer.flipX = false;

        }
        if (horizontalInput < 0)
        {

        spritePlayer.flipX = true;
        }
    }
}
