using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    private float timeSinceLastShot;
    
    public float timeBetweenShots;
    
    private void Update()
    {
        // Increment how much time has passed since the last shot was fired
        timeSinceLastShot += Time.deltaTime;
        if (timeSinceLastShot > timeBetweenShots)
        {
            timeSinceLastShot = 0;
            FireCannon();
        }
    }
    
    private void FireCannon()
    {
        // Instantiate the cannonball at the stationary ball's position
        Instantiate(cannonBallPrefab, transform.position, transform.rotation);
    }
}
