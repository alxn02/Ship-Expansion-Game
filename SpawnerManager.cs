using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public CollectibleSpawner collectibleSpawner;
    public ObstacleSpawner obstacleSpawner;

    void Start()
    {
        if (collectibleSpawner != null)
            collectibleSpawner.Begin();

        if (obstacleSpawner != null)
            obstacleSpawner.Begin();
    }
}
