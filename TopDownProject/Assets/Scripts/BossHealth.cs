using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public static LevelSelect instance = null;
    GameObject levelSign;
    int sceneIndex, levelPassed;
    [SerializeField] private int health = 100;

    private int MAX_HEALTH = 100;
    void Update()
    {

    }

    public void Damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.health -= amount;

        if (health <= 0)
        {
           BossDefeat();
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
    private void BossDefeat()
    {
        if (levelPassed < sceneIndex)
        {
            PlayerPrefs.SetInt("LevelPassed", sceneIndex);
            levelSign.gameObject.SetActive(false);
            SceneManager.LoadScene("WinScreen");
        }
    }
}