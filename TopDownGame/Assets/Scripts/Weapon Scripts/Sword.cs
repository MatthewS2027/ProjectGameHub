using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Sword : MonoBehaviour
{

    [SerializeField] private InputManager inputManager;
    [SerializeField] private Collider2D hitbox;
    // Convert enemy class to hub like player class. Access health through enemy.EnemyHealth.TakeDamage
    
    [SerializeField] private float damage = 25f;
    [SerializeField] private float attackCooldown = 0.5f;
    [SerializeField] private float attackRange = 2f;
    [SerializeField] private float attackTime = 0.3f;

    [SerializeField] private float lightAttackFreezeDur = 0.07f;

    public float GetDamage => damage;
    public float LightAttackFreezeDur => lightAttackFreezeDur;

    private void Awake()
    {
        hitbox = GetComponentInChildren<Collider2D>();
        hitbox.enabled = false;
    }

    public IEnumerator LightAttack()
    {
        Debug.Log("Sword.LightAttack");

        hitbox.enabled = true;
        yield return new WaitForSeconds(attackTime);
        hitbox.enabled = false;
        

        yield return new WaitForSeconds(attackCooldown);

    }
}
