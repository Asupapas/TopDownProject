using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossDefeat : MonoBehaviour
{
    EnemyHealthNew enemyHealthNew;
    public GameObject Boss;

    public static LevelSelect instance = null;
    
    // Start is called before the first frame update
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealthNew.health <= 10)
        {
            BossDefeated();
        }
        
    }

    public void BossDefeated()
    {
       
    }

}

