using UnityEngine;

public class Ship : MonoBehaviour
{
    public float speed = 10f;
    public int collisionCount = 0;
    public int score = 0;
    public float fuel = 100f;

    private float drainTimer = 0f;

    void Update()
    {
        // movement
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(new Vector3(moveX, moveY, 0f), Space.World);

        // fuel drain every second
        drainTimer += Time.deltaTime;
        if (drainTimer >= 1f)
        {
            fuel -= 1f;
            drainTimer = 0f;
            Debug.Log("Fuel: " + fuel);
        }

        // boundary clamp: prevents player from leaving the screen
        float clampedX = Mathf.Clamp(transform.position.x, -8f, 8f);
        float clampedY = Mathf.Clamp(transform.position.y, -4f, 4f);

        transform.position = new Vector3(clampedX, clampedY, 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        collisionCount++;
        Debug.Log("Collided with " + other.gameObject.name + " Total collisions: " + collisionCount);
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }

    public void Refuel(float amount)
    {
        fuel += amount;
        Debug.Log("Fuel: " + fuel);
    }
}
