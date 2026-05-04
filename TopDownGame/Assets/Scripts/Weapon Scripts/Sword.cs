using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Sword : MonoBehaviour
{

    [SerializeField] private InputManager inputManager;

    [SerializeField] private float damage = 25f;
    [SerializeField] private float attackCooldown = 0.5f;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
    }


    public IEnumerator LightAttack()
    {
        Debug.Log("Light attack");


        yield break;
    }
}
