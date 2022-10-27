using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 5;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        GetComponent<Animator>().SetFloat("xInput", xInput);
        GetComponent<Animator>().SetFloat("yInput", yInput);
        if (collider.GetComponent<EnemyHealthNew>() != null)
        {
            EnemyHealthNew health = collider.GetComponent<EnemyHealthNew>();
            health.Damage(damage);
        }

        if (collider.GetComponent<BossDefeated2>() != null)
        {
            BossDefeated2 health = collider.GetComponent<BossDefeated2>();
            health.Damage(damage);
        }
    }
}
