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


    private void OnTriggerStay(Collider other)
    {
        // Will not work if in the mind layer 
        if (ModeControls.IsMindLayer) return;
        
        if (other.CompareTag("Word"))
        {
            // Use the word "shield" instead of "damage" for readability
            // start it at 100% and let it drop
            // something like:
            
            // float damage = 2 * Time.fixedDeltaTime; // 2 points per second
            // shield = Mathf.Max(shield - damage, 0); // will not go below zero
        }
    }


    void Start()
    {
        UpdateUI(); 
    }
}
