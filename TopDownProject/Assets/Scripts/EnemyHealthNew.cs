using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthNew : MonoBehaviour
{
    [SerializeField] public int health = 100;

    private int MAX_HEALTH = 100;
    void Update()
    {
      
    }

    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.health -= amount;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Healing");
        }

        bool wouldBeOverMaxhealth = health + amount > MAX_HEALTH;
        
            if (wouldBeOverMaxhealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
