
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

		ApplyStatusEffects(context);
		
		TriggerHitstop(context);
		ApplyKnockback(context);

		result.finalDamage = damage;

		SendDamageToHealth(context, damage);

		return result;
	
	}

	private void ApplyStatusEffects(DamageContext context)
	{

		if(context.statusEffects == null)
			return;

		StatusEffectManager manager = context.victim.GetComponent<StatusEffectManager>();

		if(manager == null)
			return;

		foreach(StatusEffectBase effect in context.statusEffects)
		{
		
			manager.ApplyEffect(effect, context.attacker);
		
		}
 
	}

}
