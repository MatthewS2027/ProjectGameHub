
public class SlowEffect : StatusEffectBase
{

	public float slowMultiplier;

	public override void OnApply(GameObject target, StatusEffectRuntime runtime)
	{
		//Reduce movement speed
		//Reduce animation speed
	}

	public override void OnExpire(GameObject target, StatusEffectRuntime runtime)
	{
		//Restore movement speed
	}
	
}