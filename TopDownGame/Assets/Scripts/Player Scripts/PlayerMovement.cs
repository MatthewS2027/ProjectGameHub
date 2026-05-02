using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Player player;

    [SerializeField] private Rigidbody2D rb;
    private Vector2 movement;

    //Dashing variables
    private bool canDash = true;
    private bool isDashing;
    [SerializeField] private float dashTime = 0.2f;
    [SerializeField] private float dashCooldown = 0.5f;
    [SerializeField] private float dashingPower = 20f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical"); 

        movement = new Vector2(horizontal, vertical).normalized; 

        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }

    }

    private void FixedUpdate()
    {
        if (isDashing) return;

        rb.MovePosition(rb.position + player.BaseSpeed * Time.fixedDeltaTime * movement);
    }


    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;

        Vector2 dashDir;

        if (movement == Vector2.zero)
            dashDir = Vector2.right; // fallback direction
        else
            dashDir = movement.normalized;

        float startTime = Time.time;

        while (Time.time < startTime + dashTime)    //Keep dashing while current time is less than start + dash time
        {
            rb.MovePosition(rb.position + dashDir * dashingPower * Time.fixedDeltaTime);
            yield return new WaitForFixedUpdate();
        }

        isDashing = false;

        yield return new WaitForSeconds(dashCooldown);

        canDash = true;
    }

}
