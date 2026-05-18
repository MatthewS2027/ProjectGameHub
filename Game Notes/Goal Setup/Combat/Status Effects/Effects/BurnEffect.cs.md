
public class BurnEffect : StatusEffectBase
{

	public override void OnApply(GameObject target, StatusEffectRuntime runtime)
	{
		Debug.Log("Target is Burning!!!");
	}

	public override void OnTick(GameObject target, StatusEffectRuntime runtime)
	{
	
		Health health = target.GetComponent<Health>();

		if(health == null)
			return;

		float burnDamage = data.magnitude * runtime.currentStacks;

		health.TakeDamage(burnDamage);
	
	}

	public override void OnExpire(GameObject target, StatusEffectRuntime runtime)
	{
		Debug.Log("Burn ended...");
	}
	
}