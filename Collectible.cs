using UnityEngine;

public abstract class Collectible : MonoBehaviour
{
    public abstract void Collect(Ship ship);

    private void OnTriggerEnter(Collider other)
    {
        Ship ship = other.GetComponent<Ship>();
        if (ship != null)
        {
            Collect(ship);
        }
    }
}
