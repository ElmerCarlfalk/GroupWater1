using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    //Sätt variabler
    public int maxHealth;
    private int currentHealth;
    public Sprite Phase2;
    public Sprite Phase1;

    public health healthBar;

    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }

    void Start()
    {
        //Gör så man börjar på fullt health när man startar spelet
        CurrentHealth = maxHealth;
        //Koppla ihop health bar och detta script
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
        if(CurrentHealth > maxHealth)
        {
            CurrentHealth = maxHealth;
        }
        //Under 50% HP har monster phase 2-spriten på sig, och över 50% har den phase 1-spriten
        if(CurrentHealth<=maxHealth/2)
        {
            this.GetComponent<SpriteRenderer>().sprite = Phase2;
        }
        else if (CurrentHealth > maxHealth / 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = Phase1;
        }
    }
    //Gör så att alla knappar funkar
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
