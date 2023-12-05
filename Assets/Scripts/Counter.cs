using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
//Adapted from REHOPE GAMES, 2023. Timer.cs. N/A: Rehope Games.

public class Counter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    [SerializeField] public float remainingTime;
    public GameObject Player;

    private bool levelCompleted = false;

    //Sets a timer that counts down in one second increments, if the timer hits zero, the player is destroyed and is sent back to the main menu
    // Update is called once per frame
    void Update()
    {
        if (!levelCompleted && remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            counterText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else if (remainingTime <= 0)
        {
            remainingTime = 0;
            Destroy(Player);
            SceneManager.LoadScene("GameMainMenu");
            counterText.text = ("00:00");
        }
    }

    // Call this method from other scripts to indicate that the level is completed
    public void CompleteLevel()
    {
        levelCompleted = true;
        // Optionally, you can add more actions for level completion here
    }
}

