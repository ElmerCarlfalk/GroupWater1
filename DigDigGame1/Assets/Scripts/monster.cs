using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;

    public health healthBar;

    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }

    void Start()
    {
        CurrentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentHealth <= 0)
        {
            Object.Destroy(this.gameObject);
            Object.Destroy(healthBar.gameObject);
        }
    }
    public void TakeDamage()
    {
        currentHealth = currentHealth - 20;
        healthBar.SetHealth(currentHealth);
    }
    public void GetHealth()
    {
        currentHealth = currentHealth + 15;
        healthBar.SetHealth(currentHealth);
    }
}
