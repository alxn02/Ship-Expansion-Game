using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string enemyName;
    public int health = 50;

    public virtual void Move()
    {
        
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log(enemyName + " destroyed!");
        }
    }
}
