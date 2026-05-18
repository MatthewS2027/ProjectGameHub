
// Attached to anything that takes damage
public class Hurtbox : MonoBehaviour
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