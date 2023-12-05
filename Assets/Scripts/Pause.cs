using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Adapted from BRACKEYS, 2017. PauseMenu.cs. N/A: Brackeys.
//Adapted from BMO, 2020. PauseMenu.cs. N/A: BMo.

public class Pause : MonoBehaviour
{
    public bool isPaused;
    public GameObject pauseMenuUI;
    public GameObject Player;
    public PlayerRotation pr;
    public PlayerShooting ps;
    public AmmoDisplay pd;


    // Update is called once per frame

    //By default the game isn't paused
    private void Start()
    {
        isPaused = false;
    }

    //the escape key brings up the pause menu, if the menu is already paused it resumes the game
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    //if the game is in resume mode, user interactions are enabled, the pause menu is closed, and time is normal
    public void Resume()
    {
        pd.enabled = true;
        pr.enabled = true;
        ps.enabled = true;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    //if the game is in paused mode, user interactions are disabled, the pause menu is open, and time is freezed
    void Paused()
    {
        pd.enabled = false;
        pr.enabled = false;
        ps.enabled = false;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    //loads main menu when menu button is pressed
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameMainMenu");
        Resume();
        Debug.Log("Loading Menu");
    }

    //Quits the game when quit button is pressed
    public void QuitFromPauseMenu()
    {
        Application.Quit();
        Debug.Log("Qutting Game");
    }
}
