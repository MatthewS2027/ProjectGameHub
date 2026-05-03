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
    public PlayerHealth playerHealth { get; private set; }
    public PlayerCombat playerCombat { get; private set; }

    [SerializeField] private float baseSpeed = 15f;
    [SerializeField] private float maxHealth = 100f;

    public float BaseSpeed => baseSpeed;
    public float MaxHealth => maxHealth;

    private void Awake()
    {
        movement = GetComponent<PlayerMovement>();
        playerHealth = GetComponent<PlayerHealth>();
        playerCombat = GetComponent<PlayerCombat>();
    }

    
    public void Die()
    {
        Debug.Log("Player Died.");
    }
    
}
