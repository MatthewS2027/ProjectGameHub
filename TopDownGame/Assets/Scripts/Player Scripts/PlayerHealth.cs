using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private float currentHealth;
    public float CurrentHealth => currentHealth;


    void Start()
    {
        currentHealth = player.MaxHealth;
        Debug.Log("Player health: " + currentHealth);
    }

    
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("player health: " + currentHealth);

        if (currentHealth <= 0f)
        {
            player.Die();
        }
    }
     
    

}
