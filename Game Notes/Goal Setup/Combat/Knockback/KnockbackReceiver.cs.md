
// Attached to anything that can react physically
public class KnockbackReceiver : MonoBehaviour
{

	public Rigidbody targetRigidbody;

	public bool canBeLaunched = true;

	public bool canBeStaggered = true;

	public void ReceiveKnockback(KnockbackData data)
	{
	
		if(data.knockbackType == KnockbackType.Launch && !canBeLaunched)
		return;

		ApplyForce(data);
	
	}

	private void ApplyForce(KnockbackData data)
	{
	
		Vector3 finalForce = data.direction.normalized * data.force;

		if (data.ignoreMass)
			targetRigidbody.AddForce(finalForce, ForceMode.VelocityChange);
		else
			targetRigidbody.AddForce(finalForce, ForceMode.Impulse);
	
	}

	private void TriggerStagger(KnockbackData data)
	{
	
		if(!canBeStaggered)
			return;

		//Interrupt movement
		//Interrupt attacks
		//Play stagger animation
	}

}
