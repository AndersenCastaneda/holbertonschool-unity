using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void MainMenu() => SceneManager.LoadScene("MainMenu");

    public void Next()
    {
        int level = SceneManager.GetActiveScene().buildIndex;
        if (level + 1 > 3)
            MainMenu();
        else
            SceneManager.LoadScene(level + 1);
    }
}
