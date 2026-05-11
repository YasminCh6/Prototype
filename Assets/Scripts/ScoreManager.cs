using UnityEngine;
using TMPro; 

public class ScoreManager : MonoBehaviour
{
    public int currentPoints = 0;
    public int pointsToEscape = 10; 
    public GameObject Exit; 
    public TMP_Text scoreText; 

    void Start()
    {
        UpdateUI();
        if (Exit != null) Exit.SetActive(false); 
    }

    public void AddPoints(int amount)
    {
        currentPoints += amount;
        UpdateUI();
        CheckEscape();
    }

    void CheckEscape()
    {
        if (currentPoints >= pointsToEscape)
        {
            OpenEscape();
        }
    }

    void OpenEscape()
    {
        if (Exit != null)
        {
            Exit.SetActive(true); 
            Debug.Log("Escape Open!");
        }
    }

    void UpdateUI()
    {
        if (scoreText != null) scoreText.text = "Score: " + currentPoints;
    }
}

