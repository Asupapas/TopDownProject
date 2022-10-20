using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public int health = 20;
    public TextMeshProUGUI healthText;
    // Update is called once per frame
    void Update()
    {
        healthText.text = "Boss Health: " + health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "Attack")
        {
            health--;
            if (health <= 0)
            {
                SceneManager.LoadScene("WinScreen");
            }
        }
    }
}
