using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 5;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<EnemyHealthNew>() != null)
        {
            EnemyHealthNew health = collider.GetComponent<EnemyHealthNew>();
            health.Damage(damage);
        }
    }
}
