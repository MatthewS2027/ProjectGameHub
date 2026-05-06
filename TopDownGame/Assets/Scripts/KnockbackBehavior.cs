using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockbackBehavior : MonoBehaviour
{
    [Header("Knockback Settings")]
    [SerializeField] private float knockbackStrength = 8f;
    [SerializeField] private float knockbackDuration = 0.3f;

    public bool IsKnockedBack { get; private set; } = false;

    private Rigidbody2D rb;
    private Coroutine knockbackCoroutine;   //Store so that interuption is possible if coroutine should be recalled mid execution

    private void Awake()
    {
        enabled = true;
        rb = GetComponent<Rigidbody2D>();
    }

    public void ApplyKnockback(Vector2 hitSourcePos)
    {

        if (knockbackCoroutine != null)
        {

            StopCoroutine(knockbackCoroutine);

            
        }

        knockbackCoroutine = StartCoroutine(KnockbackCoroutine(hitSourcePos));

    }

    private void Update()
    {
        
    }

    private IEnumerator KnockbackCoroutine(Vector2 hitSourcePos)
    {
        Debug.Log("Knockback applied");
        IsKnockedBack = true;

        // Calculate direction opposite of attacker
        Vector2 knockbackDir = ((Vector2)transform.position - hitSourcePos).normalized;

        rb.velocity = Vector2.zero;
        //rb.AddForce takes two parameters: force, and ForceMode2D mode. Impulse adds the force at the beginning while Force mode adds over time.
        rb.AddForce(knockbackDir * knockbackStrength, ForceMode2D.Impulse); 

        yield return new WaitForSeconds(knockbackDuration);

        //reset knockback logic
        rb.velocity = Vector2.zero;
        IsKnockedBack = false;
        knockbackCoroutine = null;
    }


}
