using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ship playerShip;

    private List<Collectible> collectibles;
    private Dictionary<string, int> levelScores;

    private void Awake()
    {
        collectibles = new List<Collectible>();
        levelScores = new Dictionary<string, int>();
    }

    public void AddScore(string levelName, int amount)
    {
        // will add logic later
    }
}
