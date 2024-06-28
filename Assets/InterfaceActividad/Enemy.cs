using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public int health = 3;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Daño recibido");


        if (health <= 0)
            Destroy(gameObject);
    }
}
