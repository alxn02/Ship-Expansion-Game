using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float damageAmount = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Ship ship = other.GetComponent<Ship>();
        if (ship != null)
        {
            ship.fuel -= damageAmount;
            Debug.Log("Hit Obstacle! Fuel: " + ship.fuel);
            Destroy(gameObject);
        }
    }
}
