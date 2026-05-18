
public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int enemiesToSpawn = 3;
    [SerializeField] private float spawnInterval = 1f;

    public void Spawn()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            // Slight random offset so enemies don't stack perfectly on top of each other
            Vector2 spawnOffset = Random.insideUnitCircle * 1.5f;
            Vector3 spawnPos = transform.position + new Vector3(spawnOffset.x, spawnOffset.y, 0f);

            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 1.5f);
    }

}