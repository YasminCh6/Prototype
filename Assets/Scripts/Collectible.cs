using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

class Collectible : MonoBehaviour
{
    
    Dictionary<string, List<bool>> coinsCollected =
        new Dictionary<string, List<bool>>();
    
    private List<bool> CurrentSceneCoins()
    {
        List<bool> sceneCoins;
        string ShootingScene = SceneManager.GetActiveScene().name;
        if (!coinsCollected.TryGetValue(ShootingScene, out sceneCoins))
        {
            sceneCoins = new List<bool>();
            coinsCollected[ShootingScene] = sceneCoins;
        }
        return sceneCoins;
   
}