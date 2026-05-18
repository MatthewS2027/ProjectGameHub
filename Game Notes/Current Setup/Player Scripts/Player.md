
// This class acts as a hub for all player related scripts.

public class Player : MonoBehaviour
{
   
    public PlayerMovement movement { get; private set; }
    public PlayerHealth playerHealth { get; private set; }
    public PlayerCombat playerCombat { get; private set; }


    [SerializeField] private float baseSpeed = 15f;
    [SerializeField] private float maxHealth = 100f;

 
    public float BaseSpeed => baseSpeed;
    public float MaxHealth => maxHealth;
  

    private void Awake()
    {
        movement = GetComponent<PlayerMovement>();
        playerHealth = GetComponent<PlayerHealth>();
        playerCombat = GetComponent<PlayerCombat>();
    }

    // All Player death related logic
    public void Die()
    {
        Debug.Log("Player Died.");
        playerHealth.SetDead(true);
        movement.DisableMovement();
        playerCombat.DisableAttack();
        playerCombat.DisableSword();

        // Game Over logic

        GetComponent<SpriteRenderer>().enabled = false; // Hide player sprite
        GetComponent<Collider2D>().enabled = false; // Disable player collider
        GetComponentInChildren<SpriteRenderer>().enabled = false;
        GetComponentInChildren<Collider2D>().enabled = false;

        EnemyAI[] allEnemies = FindObjectsOfType<EnemyAI>();
        foreach (EnemyAI enemy in allEnemies)
        {
            enemy.DisableChase(); // Disable all enemy AI
        }

    }
    
}
