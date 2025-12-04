using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject starPrefab;
    public GameObject fuelPrefab;

    [Header("Spawn area")]
    public float minX = -8f;
    public float maxX = 8f;
    public float minY = -4f;
    public float maxY = 4f;

    [Header("Timing")]
    public float minSpawnTime = 2f;
    public float maxSpawnTime = 4f;

    private float timer = 0f;
    private float nextSpawnTime = 0f;

    // Called by SpawnerManager to start this spawner
    public void Begin()
    {
        SetNextSpawnTime();
    }

    void Start()
    {
        // If SpawnerManager isn't used, start automatically
        SetNextSpawnTime();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= nextSpawnTime)
        {
            SpawnCollectible();
            timer = 0f;
            SetNextSpawnTime();
        }
    }

    void SetNextSpawnTime()
    {
        nextSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void SpawnCollectible()
    {
        if (starPrefab == null || fuelPrefab == null)
        {
            Debug.LogWarning("CollectibleSpawner: assign both starPrefab and fuelPrefab in the inspector.");
            return;
        }

        Vector3 spawnPos = new Vector3(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY),
            0f
        );

        GameObject prefabToSpawn = (Random.value > 0.5f) ? starPrefab : fuelPrefab;
        Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);
    }
}
