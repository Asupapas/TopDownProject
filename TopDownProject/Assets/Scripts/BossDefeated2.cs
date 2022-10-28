using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class BossDefeated2 : MonoBehaviour
{
    int sceneIndex, levelPassed;
    [SerializeField] public int health = 100;

    private int MAX_HEALTH = 100;
    public TextMeshProUGUI healthText;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
    }

    void Update()
    {
        healthText.text = "Boss Health: " + health;
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
           if (sceneIndex == 4)
            {
                SceneManager.LoadScene("WinScreen");
            }
            else
            {
                if (levelPassed < sceneIndex)
                {
                    PlayerPrefs.SetInt("LevelPassed", sceneIndex);
                    SceneManager.LoadScene("LevelSelect");
                }
            }
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
