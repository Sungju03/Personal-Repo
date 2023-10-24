using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{   
    public static bool gameispaused = false;
    public GameObject pauseMenuUI;

    void Start()
    {
        pauseMenuUI.SetActive(true);
        gameispaused = true;
    }
    public void Open_Menu_Button()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
    }

    public void Close_Menu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;
    }

    public void Restart_Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
