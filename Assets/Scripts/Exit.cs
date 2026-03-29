using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;


public class Exit : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with exit");
            Object.FindFirstObjectByType<GameManager>().TriggerGameExit();
        }    
    }

   
}
