using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public List<Collectible> collectibles = new List<Collectible>();

    void Start()
    {
        
        Collectible[] foundCollectibles =
            GameObject.FindObjectsByType<Collectible>(FindObjectsSortMode.None);
        collectibles.AddRange(foundCollectibles);
    }

    public void RemoveCollectible(Collectible c)
    {
        if (collectibles.Contains(c))
        {
            collectibles.Remove(c);
        }
    }
}
