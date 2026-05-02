using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Player player;

    [SerializeField] private Rigidbody2D rb;
    private Vector2 movement;

    //Dashing variables
    /*
    private bool canDash = true;
    private bool isDashing = false;
    private float dashTime = 0.2f;
    private float dashCooldown = 0.5f;
    */

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

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + player.BaseSpeed * Time.fixedDeltaTime * movement);
    }

    /*
    private IEnumerator Dash()
    {
        
    }
    */

}
