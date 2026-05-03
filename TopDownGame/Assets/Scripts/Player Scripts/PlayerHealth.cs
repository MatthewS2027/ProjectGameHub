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
    private bool isDead = false;


    void Start()
    {
        currentHealth = player.MaxHealth;
        Debug.Log("Player health: " + currentHealth);
    }

    
    public void TakeDamage(float damage)
    {
        if (currentHealth > 0 && !isDead)
        {
            currentHealth -= damage;
        }
        Debug.Log("Player health: " + currentHealth);

        if (currentHealth <= 0f)
        {
            isDead = true;
            player.Die();
        }
    }

    public void SetDead(bool value)
    {
        isDead = value;
    }



}
