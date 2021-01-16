﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    // Start is called before the first frame update
    public void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    public void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
