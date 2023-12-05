using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//Adapted from BMO, 2020. Interactable.cs. N/A: BMo.

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactionAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Checks if the the player is in range and if they have pressed the interact key, if so it invokes the event listener on the GameObject
    void Update()
    {
        if(isInRange)
        {
            if(Input.GetKeyDown(interactKey))
            {
                interactionAction.Invoke();
            }
        }
    }

    //Checks if the player is in range of the GameObject
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player is now in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player is now not in range");
        }
    }
}
