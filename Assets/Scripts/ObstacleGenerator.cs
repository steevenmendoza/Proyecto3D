using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab; 
    public float spawnInterval = 2f; 
    public Transform playerTransform; 
    public float spawnDistanceAhead = 30f; 
    public float spawnWidth = 20f; 
    public float minHeight = 10f; 
    public float maxHeight = 20f; 
    public float spawnDepth = 30f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            GenerateObstacleAheadOfPlayer();
            timer = 0;
        }
    }

    void GenerateObstacleAheadOfPlayer()
{
    float randomXOffset = Random.Range(-spawnWidth / 2, spawnWidth / 2);
    float randomZOffset = Random.Range(-spawnDepth / 2, spawnDepth / 2); // Asumiendo que tienes un nuevo parámetro spawnDepth
    float randomHeight = Random.Range(minHeight, maxHeight);

    Vector3 spawnPosition = new Vector3(playerTransform.position.x + randomXOffset, randomHeight, playerTransform.position.z + randomZOffset);

    Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
}
}
