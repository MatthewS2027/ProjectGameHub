
// We love polymorphism
// Base behavior for all effects
public abstract class StatusEffectBase : ScriptableObject
{

	public StatusEffectData data;

	public virtual void OnApply(GameObject target, StatusEffectRuntime runtime)
	{
	
		// Spawn VFX
		// Initial effect logic
	
	}

	public virtual void OnTick(GameObject target, StatusEffectRuntime runtime)
	{
	
		// Periodic Logic
	
	}

	public virtual void OnExpire(GameObject target, StatusEffectRuntime runtime)
	{
	
		// Cleanup Logic
	
	}

}