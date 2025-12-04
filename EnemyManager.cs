using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Dictionary<string, Enemy> enemies = new Dictionary<string, Enemy>();

    void Start()
    {
        
        Enemy[] foundEnemies = GameObject.FindObjectsByType<Enemy>(FindObjectsSortMode.None);
        foreach (Enemy e in foundEnemies)
        {
            if (!enemies.ContainsKey(e.enemyName))
            {
                enemies.Add(e.enemyName, e);
            }
        }
    }

    public void RemoveEnemy(string name)
    {
        if (enemies.ContainsKey(name))
        {
            enemies.Remove(name);
        }
    }
} 
