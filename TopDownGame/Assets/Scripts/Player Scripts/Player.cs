using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* 
 * This class will act as a hub for all player related scripts.
 * This currently includes:
 * - PlayerMovement
 * - PlayerHealth
 * - PlayerCombat
*/
public class Player : MonoBehaviour
{
   
    public PlayerMovement movement { get; private set; }

    [SerializeField] private float baseSpeed = 15f;

    public float BaseSpeed => baseSpeed;

    private void Awake()
    {
        movement = GetComponent<PlayerMovement>();
    }

    /*
    public void Die()
    {
        Debug.Log("Player Died.");
    }
    */
}
