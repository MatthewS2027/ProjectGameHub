
public class SpawnManager : MonoBehaviour
{
    Header("Spawners")
    [SerializeField] private EnemySpawner spawner1;
    [SerializeField] private EnemySpawner spawner2;
    [SerializeField] private EnemySpawner spawner3;

    [Header("Timing")]
    [SerializeField] private float delayBetweenSpawners = 1f;  
    [SerializeField] private float initialDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RunSpawnSequence());
    }

    private IEnumerator RunSpawnSequence()
    {
        yield return new WaitForSeconds(initialDelay);
        
        if (spawner1 != null)
        {
            spawner1.Spawn();
        }

        if (spawner2 != null)
        {
            spawner2.Spawn();
        }

        if (spawner3 != null)
        {
            spawner3.Spawn();
        }

    }

}