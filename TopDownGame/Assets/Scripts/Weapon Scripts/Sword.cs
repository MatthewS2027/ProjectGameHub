using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Sword : MonoBehaviour
{

    [SerializeField] private InputManager inputManager;
    [SerializeField] private Collider2D hitbox;
    private SpriteRenderer sr;
    Color originalColor;
    // Convert enemy class to hub like player class. Access health through enemy.EnemyHealth.TakeDamage

    [SerializeField] private float damage = 25f;
    [SerializeField] private float attackCooldown = 0.5f;
    [SerializeField] private float attackRange = 2f;
    [SerializeField] private float attackTime = 0.08f;

    [SerializeField] public float lightAttackFreezeDur = 0.3f;

    public float GetDamage => damage;
    public float LightAttackFreezeDur => lightAttackFreezeDur;

    private void Awake()
    {
        hitbox = GetComponentInChildren<Collider2D>();
        hitbox.enabled = false;
        sr = hitbox.GetComponent<SpriteRenderer>();
        originalColor = sr.color;

    }

    public IEnumerator LightAttack()
    {

        StartCoroutine(AttackFlash());

        hitbox.enabled = true;
        Debug.Log("hitbox activated");

        float elapsed = 0f;

        while (elapsed < attackTime)
        {
            elapsed += Time.deltaTime;
            yield return null;
        }

        //yield return new WaitForSecondsRealtime(attackTime);

        Debug.Log("hitbox deactivated");
        hitbox.enabled = false;
        
        yield return new WaitForSeconds(attackCooldown);

    }

    private IEnumerator AttackFlash()
    {
        if (sr == null) yield break;


        sr.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        sr.color = originalColor;


    }
}
