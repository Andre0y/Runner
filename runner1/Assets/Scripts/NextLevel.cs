using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex != 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1;
        }
        if (SceneManager.GetActiveScene().buildIndex != 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
            Time.timeScale = 1;
        }
    }
}
