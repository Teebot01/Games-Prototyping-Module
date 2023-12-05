using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//Adapted from SPEEDTUTOR, 2017. Assets\UIAppear.cs. N/A: SpeedTutor.

public class UIDoor : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI notificationDisplay;

    //Determines when the player is in range to interact with the door GameObject
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (notificationDisplay != null)
            {
                notificationDisplay.enabled = true;
                Debug.Log("Notification has appeared");
            }
            else
            {
                Debug.LogError("Notification display is not assigned!");
            }
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            notificationDisplay.enabled = false;
            Debug.Log("Notification has disappeared");
        }
    }
}