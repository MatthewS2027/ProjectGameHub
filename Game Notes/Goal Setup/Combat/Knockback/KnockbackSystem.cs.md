
public class KnockbackSystem : MonoBehaviour
{

	public static KnockbackSystem Instance;

	public void ApplyKnockback(DamageContext context)
	{

		if(!context.applyKnockback)
			return;

		KnockbackReceiver receiver = context.victim.GetComponent<KnockbackReceiver>();
		if(receiver == null)
			return;

		KnockbackData data = new KnockbackData();

		data.direction = context.hitDirection;
		data.force = context.knockbackForce;
		data.knockbackType = context.knockbackType;

		receiver.ReceiveKnockback(data);

	}
}