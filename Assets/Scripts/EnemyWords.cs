using UnityEngine;

public class EnemyWords : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth player = collision.gameObject.GetComponent<PlayerHealth>();
            if (player != null)
            {
                player.TakeHit(20f); // every bullet +20%
            }
            
            Destroy(gameObject);
        }
        
    }
}
