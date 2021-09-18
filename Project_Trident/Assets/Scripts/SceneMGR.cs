using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneMGR : MonoBehaviour
{
    public bool splash;
    public GameObject SplashScreen;
    public GameObject pauseMenuPanel;
    public GameObject mainMenuPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuPanel.SetActive(true);
            mainMenuPanel.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && splash == false)
        {
            SplashScreen.SetActive(false);
            mainMenuPanel.SetActive(true);
            splash = true;
        }
    }
    public void resume ()
    {
        pauseMenuPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(1);

    }
}
