using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winscreen : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("Volcano");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
