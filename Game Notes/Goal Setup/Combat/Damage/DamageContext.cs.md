
public class DamageContext : MonoBehaviour
{

	public GameObject attacker;
	public GameObject victim;

	public float baseDamage;

	public DamageType damageType;

	public Vector3 hitPoint;
	public Vector3 hitDirection;

	//crit logic

	public bool applyKnockback;
	public float knockbackForce;
	public KnockbackType knockbackType;

	public List<StatusEffectBase> statusEffects;

	//element logic

	public GameObject sourceWeapon;

	public float stunDuration;

}