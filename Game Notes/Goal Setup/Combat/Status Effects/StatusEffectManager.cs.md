
// Handles active status effects
public class StatusEffectManager : MonoBehaviour
{

	public List<StatusEffectRunTime> activeEffects;

	private void Update()
	{
		UpdateEffects(Time.deltaTime);
	}

	private void UpdateEffects(float deltaTime)
	{
	
		for(int i = activeEffects.Count - 1; i >= 0; i--)
		{

			StatusEffectRuntime runtime = activeEffects[i];

			runtime.remainingDuration -= deltaTime;
			runtime.tickTimer -= deltaTime;

			if(runtime.tickTimer <= 0)
			{
				runtime.tickTimer = runtime.effect.data.tickRate;
				runtime.effect.OnTick(gameObject, runtime);
			}

			if(runtime.remainingDuration <= 0)
			{
				runtime.effect.OnExpire(gameObject, runtime);
				activeEffects.RemoveAt(i);
			}

		}
	
	}

	private void ApplyEffect(StatusEffectBase effect, GameObject source)
	{

		StatusEffectRuntime existing = FindExistingEffect(effect);

		if(existing != null)
		{
		
			if(effect.data.canStack)
			{
			
				existing.currentStacks++;

				existing.currentStacks = Mathf.Min(existing.currentStacks, effect.data.maxStacks);
				
			
			}

			existing.remainingDuration = effect.data.duration;

			return;
		
		}

		StatusEffectRuntime runtime = new StatusEffectRuntime();

		runtime.effect = effect;
		runtime.source = source;
		
		runtime.remainingDuration = effect.data.duration;
		
		runtime.tickTimer = effect.data.tickRate;
		
		runtime.currentStacks = 1;
		
		activeEffects.Add(runtime);
		effect.OnApply(gameObject, runtime);

	
	}

	private StatusEffectRuntime FindExistingEffect(StatusEffectBase effect)
	{
	
		foreach (StatusEffectRuntime runtime in activeEffects)
		{
			if(runtime.effect == effect)
				return runtime;
		}

		return null;
	
	}


}