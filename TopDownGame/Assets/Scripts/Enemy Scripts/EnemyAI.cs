using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 13f;
    [SerializeField] private float damagePerHit = 10f;
    [SerializeField] private float damageCooldown = 1f;  // Time in seconds between damage applications
    [SerializeField] private float detectionRange = 10f; // How far an enemy can 'see' the player from

    private Transform playerTransform;
    private Rigidbody2D rb;
    private float lastDamageTime; // Tracks the last time damage was applied to the player

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            playerTransform = playerObj.transform;
        }
        else
        {
            Debug.LogError("Enemy AI: No GameObject with tag 'Player' found");
        }
    }

    private void FixedUpdate()
    {
        if (playerTransform == null) return;

        float distance = Vector2.Distance(rb.position, playerTransform.position);

        if (distance <= detectionRange)
        {
            Vector2 direction= ((Vector2)playerTransform.position - rb.position).normalized;
            rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * direction);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        //Cooldown check
        if (Time.time < lastDamageTime + damageCooldown) return;

        PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        if(playerHealth != null)
        {
            playerHealth.TakeDamage(damagePerHit);
            lastDamageTime = Time.time; // Update the last damage time
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }

}
