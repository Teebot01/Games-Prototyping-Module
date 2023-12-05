using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Adapted from BMO, 2020. PlayerManager.cs. N/A: BMo.

public class PlayerManagement : MonoBehaviour
{
    public float bombsDisarmed;
    public float bombsRequired = 3; // Variable to store the required number of bombs
    public AudioSource audioSourceCheering;
    public AudioClip Cheering;

    private bool canInteractWithBox = false;

    public Counter counterScript;

    //Checks if the player is in range to interact with the door
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("InteractableBox"))
        {
            canInteractWithBox = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InteractableBox"))
        {
            canInteractWithBox = false;
        }
    }

    //Key to press when the player can interact with the door
    void Update()
    {
        if (canInteractWithBox && Input.GetKeyDown(KeyCode.E))
        {
            InteractWithBox();
        }
    }

    //If the player has enough bombs to complete the level, they beat the level, if not they can't interact with the door
    private void InteractWithBox()
    {
        if (bombsDisarmed >= bombsRequired) // Use the bombsRequired variable here
        {
            Debug.Log("Player has beaten level");
            audioSourceCheering.clip = Cheering;
            audioSourceCheering.Play();
            

            // Check if counterScript is not null
            if (counterScript != null)
            {
                Debug.Log("Calling CompleteLevel from PlayerManagement");
                counterScript.CompleteLevel();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                Debug.LogError("counterScript is null");
            }

            // Optionally, you can add more actions for level completion here

            // Reset the conditions to prevent multiple executions
            bombsDisarmed = 0;
            canInteractWithBox = false;
        }
        else
        {
            Debug.Log("Not enough bombs disarmed to beat the level by interacting with the box");
        }
    }

    // Add this method to match the expected method in other scripts
    public void DisarmTheBomb()
    {
        bombsDisarmed += 1f;
    }
}


