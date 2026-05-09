using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoint;
    
    // Update is called once per frame
    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
