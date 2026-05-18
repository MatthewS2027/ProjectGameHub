
// Implement HashSet<'Hurtbox'> hitTargets;
// This is to prevent double hits
public class Hitbox : MonoBehaviour
{

	public float baseDamage;

	public DamageType damageType;

	private void OnTriggerEnter(Collider other)
	{
		Hurtbox hurtbox = other.GetComponent<Hurtbox>();

		if(hurtbox == null)
			return;

		DamageContext context = new DamageContext();

		context.attacker = gameObject;
		context.baseDamage = baseDamage;
		context.damageType = damageType;

		context.hitDirection = (other.transform.position - transform.position).normalized;

		hurtbox.ReceiveHit(context);
	}

}