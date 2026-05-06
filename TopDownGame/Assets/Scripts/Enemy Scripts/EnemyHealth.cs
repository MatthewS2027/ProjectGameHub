using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 50f;
    private float currentHealth;
    private bool isDead;

    private SpriteRenderer spriteRenderer;

    // Color of enemy
    [SerializeField] private string hexColor = "#4E70E2";
    private Color newColor;

    private KnockbackBehavior knockback;

    void Awake()
    {
        currentHealth = maxHealth;
        isDead = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
        knockback = GetComponent<KnockbackBehavior>();
    }

    
    public void TakeDamage(float damage, Vector2 attackerPos)
    {
        if (isDead) return;

        currentHealth -= damage;

        //Damage Effects
        StartCoroutine(DamageFlash());
        
        if (currentHealth <= 0)
        {
            Die();
        }
        
    }

    private IEnumerator DamageFlash()
    {
        if (spriteRenderer == null) yield break;

        spriteRenderer.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = new Color(78f / 255f, 112f / 255f, 226f / 255f);

    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        this.gameObject.GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject);
    }

}
