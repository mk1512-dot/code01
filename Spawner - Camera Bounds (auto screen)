public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 1.5f;

    float minX, maxX;
    float spawnY;

    void Start()
    {
        Camera cam = Camera.main;

        float height = cam.orthographicSize;
        float width = height * cam.aspect;

        Vector3 camPos = cam.transform.position;

        minX = camPos.x - width;
        maxX = camPos.x + width;

        spawnY = camPos.y + height + 1f; // spawn phía trên màn

        InvokeRepeating("SpawnCoin", 1f, spawnInterval);
    }

    void SpawnCoin()
    {
        float randomX = Random.Range(minX, maxX);

        Vector2 spawnPos = new Vector2(randomX, spawnY);

        Instantiate(coinPrefab, spawnPos, Quaternion.identity);
    }
}
