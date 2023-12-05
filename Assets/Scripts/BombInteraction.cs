using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInteraction : MonoBehaviour
{
    public bool isDisarmed = false; // Make sure it starts as false
    public GameObject smokeParticle;
    public AudioSource audioSourceBeep;
    public AudioClip Beep;
    public GameObject destructableCollider;
    public PlayerManagement playerManagement; // Reference to the PlayerManagement script

    //Finds objects with the player tag through the playerManagement script
    public void Start()
    {
        playerManagement = GameObject.FindWithTag("Player").GetComponent<PlayerManagement>();
    }

    //Destroys the smoke particle effect and destroys the interaction collider to prevent exploits
    public void DisarmBomb()
    {
        if (!isDisarmed)
        {
            isDisarmed = true;
            Debug.Log("Bomb is now disarmed");
            Destroy(smokeParticle);
            audioSourceBeep.clip = Beep;
            audioSourceBeep.Play();
            Destroy(destructableCollider);

            // Notify PlayerManagement that a bomb is disarmed

            playerManagement.bombsDisarmed += 1f;
        }
    }
}

