
### [Damage Dealing]
#### DamageContext.cs

// Damage methods use this pipeline
public class DamageContext : MonoBehaviour
{

	public GameObject attacker;
	public GameObject victim;

	public float baseDamage;

	public DamageType damageType;

	public Vector3 hitPoint;
	public Vector3 hitDirection;

	//crit logic

	public bool applyKnockback;
	public float knockbackForce;

	//public List<StatusEffectData> statusEffects;

	//element logic

	public GameObject sourceWeapon;

	public float stunDuration;

}


#### DamageResult.cs

public class DamageResult : MonoBehaviour
{

	public float finalDamage;

	public bool killedTarget;

	public bool appliedStatusEffect;

	public Vector3 finalKnockback;

}

#### DamageSystem.cs

public class DamageSystem : MonoBehaviour
{

	// Receives DamageContext
	// Returns DamageResult
	// Sends final damage to Health

	public static DamageSystem Instance;

	public DamageResult ProcessHit(DamageContext context)
	{
	
		DamageResult result = new DamageResult();

		float damage = context.baseDamage;

		damage = ApplyArmor(context, damage);
		damage = ApplyResistances(context, damage);
		damage = ApplyWeakpointModifiers(context, damage);

		TriggerStatusEffects(context);
		TriggerHitstop(context);
		ApplyKnockback(context);

		result.finalDamage = damage;

		SendDamageToHealth(context, damage);

		return result;
	
	}

}


### [Health]

#### Health.cs

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


### [DamageReceiver]

// Attached to anything that takes damage
public class DamageReceiver : MonoBehaviour
{

	public Health ownerHealth;

	[SerializeField] public float damageMultiplier = 1f;

	public bool isWeakpoint;

	public void ReceiveHit(DamageContext context)
	{

		context.victim = ownerHealth.gameObject;
		context.baseDamage *= damageMultiplier;

		context.isWeakpointHit = isWeakpoint;

		DamageSystem.Instance.ProcessHit(context);
	}

}


### [Hitbox]

// Implement HashSet<'DamageReceiver'> hitTargets;
// This is to prevent double hits
public class Hitbox : MonoBehaviour
{

	public float baseDamage;

	public DamageType damageType;

	private void OnTriggerEnter(Collider other)
	{
		DamageReceiver receiver = other.GetComponent<DamageReceiver>();

		if(receiver == null)
			return;

		DamageContext context = new DamageContext();

		context.attacker = gameObject;
		context.baseDamage = baseDamage;
		context.damageType = damageType;

		context.hitDirection = (other.transform.position - transform.position).normalized;

		receiver.ReceiveHit(context);
	}

}

### Example Combat Flow

- Player uses basic sword attack
- Hitbox script is activated
- DamageContext is created (attacker, baseDamage, damageType, hitDirection)
- Constructed context is sent to receiver.ReceiveHit
- New variables set in context (receiver, apply damage modifier, if weak point)
- Complete context is passed to DamageSystem.instance.ProcessHit
- Modifiers and effects are set
- Final damage and context are sent to Health
- Effects and damage are applied to receiver