using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    [SerializeField] private Sword sword;
    [SerializeField] private Transform playerTransform;

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
            enemy.TakeDamage(sword.GetDamage, playerTransform.position);

            
            if (HitStop.instance != null)
            {
                HitStop.instance.ExecHitStop(sword.LightAttackFreezeDur);
            }
            
            if (collision.TryGetComponent<KnockbackBehavior>(out var enemyKnockback))
            {
                enemyKnockback.ApplyKnockback(transform.root.position);
            }

        }
        
    }
    

}
