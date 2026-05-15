using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{ 
    public GameObject gameOverScreen;
    public GameObject gameExit;
    public GameObject startScreen;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverScreen.SetActive(false);   
        gameExit.SetActive(false);
        startScreen.SetActive(true);
        Time.timeScale = 0f;

    }

    public void PlayGame()
    {
      SceneManager.LoadScene("NormalVision");
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("MusicMenu");
    }

    public void TriggerGameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void TriggerGameExit()
    {
        gameExit.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
