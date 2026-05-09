using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Scenes/NormalVision");
        }
        else
        
        if(Keyboard.current.gKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Scenes/ShootingScene");
        }
    }
}
