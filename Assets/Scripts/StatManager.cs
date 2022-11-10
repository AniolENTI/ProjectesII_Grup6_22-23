using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public int essence;
    public int maxEssence;
    public int attack;

    public HealthBar healthBar;
    public EssenceBar essenceBar;

    private void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        essenceBar.SetMaxEssence(maxEssence, essence);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            loseHealth(10);
            loseEssence(2);
        }
    }

    public void gainHealth(int amount)
    {
        health += amount;
        if(health > maxHealth)
        {
            health = maxHealth;
        }
        healthBar.SetHealth(health);
    }
    public void loseHealth(int amount)
    {
        health -= amount;
        if(health < 0)
        {
            health = 0;
        }
        healthBar.SetHealth(health);
    }
    public void gainEssence(int amount)
    {
        essence += amount;
        if(essence > maxEssence)
        {
            essence = maxEssence;
        }
        essenceBar.SetEssence(essence);
    }
    public void loseEssence(int amount)
    {
        essence -= amount;
        if(essence < 0)
        {
            essence = 0;
        }
        essenceBar.SetEssence(essence);
    }
}
