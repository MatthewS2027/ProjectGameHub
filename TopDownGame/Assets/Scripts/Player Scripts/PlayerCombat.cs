using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Remember the PURPOSE: Only when to attack. Future: Implement for all Heavy attacks / ability casts
 * 
 */

public class PlayerCombat : MonoBehaviour
{

    private Player player;
    [SerializeField] private Sword sword;

    private bool isAttacking;

    private void Awake()
    {
        player = GetComponent<Player>();
        isAttacking = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Light Attack
        if (Input.GetMouseButtonDown(0) && isAttacking == false)
        {
            isAttacking = true;
            StartCoroutine(sword.LightAttack());
            isAttacking = false;
        }

        // Future: Add input for heavy attack / ability casts

    }

    
    public void EnableHitbox()
    {
        GetComponentInChildren<Collider2D>().enabled = true;
    }

    //Methods are called when player dies
    public void DisableAttack()
    {
        enabled = false;
    }

    public void DisableSword()
    {
        GetComponentInChildren<Collider2D>().enabled = false;
        GetComponentInChildren<SpriteRenderer>().enabled = false;
    }
    
}
