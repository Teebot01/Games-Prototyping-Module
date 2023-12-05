using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Adapted from BMO, 2020. MainMenu.cs. N/A: BMo.
//Adapted from BRACKEYS, 2017. MainMenu.cs. N/A: Brackeys.

public class MainMenu : MonoBehaviour
{
    //When the play button is clicked, load the next scene in the build
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //When the quit button is pressed, quits the application
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

}
