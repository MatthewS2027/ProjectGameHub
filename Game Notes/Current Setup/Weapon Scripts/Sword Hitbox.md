
public class SwordHitbox : Sword
{
    [SerializeField] private Sword sword;

    private void Awake()
    {
        sword = GetComponentInParent<Sword>(); 

        if (sword == null)
        {
            Debug.LogError("Sword not found");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.TryGetComponent<EnemyHealth>(out var enemy))
        {
            enemy.TakeDamage(sword.GetDamage);

            if (HitStop.instance != null)
            {
                Debug.Log("Before Hitstop");
                HitStop.instance.ScreenFreeze(sword.LightAttackFreezeDur);
                Debug.Log("After Hitstop");
            }
            else
            {
                Debug.Log("Hitstop instance is NULL");
            }
        }
        
    }


}