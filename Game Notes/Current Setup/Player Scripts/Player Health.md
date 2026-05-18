
public class PlayerHealth : MonoBehaviour
{
    private Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private float currentHealth;
    public float CurrentHealth => currentHealth;
    private bool isDead = false;
    private float damageTime = 0.5f


    void Start()
    {
        currentHealth = player.MaxHealth;
        Debug.Log("Player health: " + currentHealth);
    }

    
    public void TakeDamage(float damage)
    {

		if (I_Frames.instance.IFramesActive)
		{
			Debug.Log("I-Frames Active!");
			return;
		}

        if (currentHealth > 0 && !isDead)
        {
            currentHealth -= damage;
        }
        Debug.Log("Player health: " + currentHealth);

		I_Frames.instance.execIFrames(damageTime);

        if (currentHealth <= 0f)
        {
            isDead = true;
            player.Die();
        }
    }

    public void SetDead(bool value)
    {
        isDead = value;
    }

}