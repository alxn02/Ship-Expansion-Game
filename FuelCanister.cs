using UnityEngine;

public class FuelCanister : MonoBehaviour
{
    public float fuelAmount = 20f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Ship ship = other.GetComponent<Ship>();
        if (ship != null)
        {
            ship.Refuel(fuelAmount);
            ship.AddScore(10);
            Debug.Log("Collected Fuel");
            Destroy(gameObject);
        }
    }
}
