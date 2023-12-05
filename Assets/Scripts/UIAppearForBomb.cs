using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//Adapted from SPEEDTUTOR, 2017. Assets\UIAppear.cs. N/A: SpeedTutor.

public class UIAppearForBomb : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI notificationDisplay;

    //If the player is in interactable range of a bomb, an interaction notification appears, if they move away, the notification disappears
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
