using UnityEngine;

public class Star : MonoBehaviour
{
    public int scoreValue = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Ship ship = other.GetComponent<Ship>();
        if (ship != null)
        {
            ship.AddScore(scoreValue);
            Debug.Log("Collected Star");
            Destroy(gameObject);
        }
    }
}
