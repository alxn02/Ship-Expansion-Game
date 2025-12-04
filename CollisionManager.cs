using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public Ship ship;
    public List<Collectible> collectibles = new List<Collectible>();
    public List<Enemy> enemies = new List<Enemy>();

    void Update()
    {
        CheckCollectibles();
        CheckEnemies();
    }

    void CheckCollectibles()
    {
        for (int i = collectibles.Count - 1; i >= 0; i--)
        {
            Collectible c = collectibles[i];
            if (c != null && Vector3.Distance(ship.transform.position, c.transform.position) < 1f)
            {
                c.Collect(ship);
                collectibles.RemoveAt(i);
            }
        }
    }

    void CheckEnemies()
    {
        foreach (Enemy e in enemies)
        {
            if (e != null && Vector3.Distance(ship.transform.position, e.transform.position) < 1f)
            {
                Debug.Log("Ship hit by enemy: " + e.enemyName);
                
            }
        }
    }
}
