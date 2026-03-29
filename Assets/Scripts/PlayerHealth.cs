using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public float damagePercent = 0f;
    public TMP_Text healthText;

    public void TakeHit(float amount)
    {
        damagePercent += amount;

        if (damagePercent >= 100f)
        {
            damagePercent = 100f;
            Die();
        }
        UpdateUI();
    }
    void UpdateUI()
    {
        healthText.text = "Vulnerability: " + Mathf.RoundToInt(damagePercent) + "%";
    }

    void Die()
    {
        Debug.Log("Player dead");
        Object.FindFirstObjectByType<GameManager>().TriggerGameOver();

    }
    
    
    
    void Start()
    {
        UpdateUI(); 
    }
}
