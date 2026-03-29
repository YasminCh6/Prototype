using UnityEngine;

public class WallCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile") || collision.gameObject.CompareTag("Word"))
        {
            Destroy(gameObject);
        }
    }
}
