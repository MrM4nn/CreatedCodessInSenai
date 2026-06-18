using UnityEngine;

public class Colletable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.CompareTag("Player"))
        {

            PlayerMove.playerCoins++;
            Debug.Log("Coins count: " + PlayerMove.playerCoins);
            Destroy(gameObject);

        }
    }
}
