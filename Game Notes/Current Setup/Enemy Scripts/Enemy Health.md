
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 50f;
    private float currentHealth;
    private bool isDead;

    private SpriteRenderer spriteRenderer;

    // Color of enemy
    [SerializeField] private string hexColor = "#4E70E2";
    private Color newColor;


    void Awake()
    {
        currentHealth = maxHealth;
        isDead = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float damage)
    {
        if (isDead) return;

        currentHealth -= damage;
        Debug.Log("Enemy health: " + currentHealth);

        //Damage Effects
        StartCoroutine(DamageFlash());
        
        if (currentHealth <= 0)
        {
            Die();
        }
        
    }

    private IEnumerator DamageFlash()
    {
        Debug.Log("in DamageFlash enumerator");
        if (spriteRenderer == null) yield break;

        spriteRenderer.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = new Color(78f / 255f, 112f / 255f, 226f / 255f);
        Debug.Log("leaving DamageFlash enumerator");

    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        this.gameObject.GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject);
    }

}