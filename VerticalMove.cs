using UnityEngine;

public class MovimentoSecundario : MonoBehaviour
{


    private Rigidbody2D physicsPlayer;

    private float verticalInput;

    public float moveSpeed = 5f;


   
    void Start()
    {

       physicsPlayer = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        //armazena na variavel os inputs verticais (apertadas cima e baixo(w e s))
        verticalInput = Input.GetAxis("Vertical");

        physicsPlayer.linearVelocity = new Vector2(physicsPlayer.linearVelocity.x, verticalInput * moveSpeed);
      
    }
}
