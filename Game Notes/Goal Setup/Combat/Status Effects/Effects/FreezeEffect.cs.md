
public class FreezeEffect : StatusEffectBase
{

	public override void OnApply(GameObject target, StatusEffectRuntime runtime)
	{
		//Disable movement
		//Disable actions
		//Play freeze VFX
	}

	public override void OnExpire(GameObject target, StatusEffectRuntime runtime)
	{
		//Restore movement
		//Remove freeze VFX
	}
	
}