using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectible : MonoBehaviour
{
    // This is just an example - you can implement this in health instead (to add more health in Mind)
    private void OnTriggerEnter(Collider other)
    {
        // Be careful with colliders - 2D and 3D don't interact
        if (!ModeControls.IsMindLayer) return; // Not on the mind layer, stop here
        
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    // NOT SURE THIS IS NEEDED
    // Dictionary<string, List<bool>> coinsCollected =
    //     new Dictionary<string, List<bool>>();
    //
    // private List<bool> CurrentSceneCoins()
    // {
    //     List<bool> sceneCoins;
    //     string ShootingScene = SceneManager.GetActiveScene().name;
    //     if (!coinsCollected.TryGetValue(ShootingScene, out sceneCoins))
    //     {
    //         sceneCoins = new List<bool>();
    //         coinsCollected[ShootingScene] = sceneCoins;
    //     }
    //
    //     return sceneCoins;
    // }
}