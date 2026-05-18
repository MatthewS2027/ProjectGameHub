
// This class will only be passed final damage.
public class Health : MonoBehaviour
{

	public float maxHealth;
	public float currentHealth;

	public bool isDead;

	public void TakeDamage(float damage)
	{
		if (isDead)
		return;

		currentHealth -= damage;

		if(currentHealth <= 0)
		{
			Die();
		}
	}

	public void Heal(float amount)
	{
		currentHealth += amount;
		currentHealth = Mathf.Min(currentHealth, maxHealth);
	}

	private void Die()
	{
		isDead = true;
		//Death logic
	}
}