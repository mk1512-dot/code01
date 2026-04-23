public class CoinSpawner : MonoBehaviour
{
    [Header("Prefab")]
    [SerializeField] GameObject coinPrefab;

    [Header("Spawn Settings")]
    [SerializeField] float spawnInterval = 1.5f;

    [Header("Spawn Range X")]
    [SerializeField] float minX = -5f;
    [SerializeField] float maxX = 5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnCoin), 1f, spawnInterval);
    }

    void SpawnCoin()
    {
        // Random vị trí ngang
        float randomX = Random.Range(minX, maxX);

        // Giữ nguyên Y của SpawnPoint
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);

        Instantiate(coinPrefab, spawnPos, Quaternion.identity);
    }
}
