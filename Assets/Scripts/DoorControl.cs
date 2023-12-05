using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Adapted from BMO, 2020. DoorController.cs. N/A: BMo.

public class DoorControl : MonoBehaviour
{
    public bool Open;

    private UIAppearForBomb uiScript;
    private PlayerManagement playerManager;

    void Start()
    {
        //Finds the child object "Interactable Box" and assigns the transform to "InteractableBoxTransform"
        Transform interactableBoxTransform = transform.Find("Interactable Box");

        //If "Interactable Box" is found, gets the "UIAppearForBomb" component attached and assigns it to uiScript
        if (interactableBoxTransform != null)
        {
            uiScript = interactableBoxTransform.GetComponent<UIAppearForBomb>();
        }
        //If "Interactable Box" is not found, display debug message:
        else
        {
            Debug.LogError("Interactable box not found!");
        }

        //Finds the GameObject labelled with the tag "Player" and gets the "PlayerManangement" component attached, and assigns it to "playerMananger"
        playerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManagement>();
    }

    void Update()
    {
        //Checks if the interaction key is pressed and that the door isn't open
        if (Input.GetKeyDown(KeyCode.E) && !Open)
        {
            //Checks that the UI script is enabled
            if (uiScript != null && uiScript.enabled)
            {
                //Calls the DisarmThebomb methood from the playerManager script if not null
                // Assuming the bombsDisarmed check is in the PlayerManagement script
                if (playerManager != null)
                {
                    playerManager.DisarmTheBomb(); // Trigger disarming when the door is interacted with
                }
            }
        }
    }
}

