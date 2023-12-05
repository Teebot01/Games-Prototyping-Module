using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//Adapted from JGN GAMES, 2018 . AmmoDisplay.cs. N/A: JGN Games.

public class BombCounter : MonoBehaviour
{
    public float bombsRemaining;
    public bool bombDisarmed;
    public TextMeshProUGUI bombDisplay;
    public string slash = "/";
    public GameObject player;
    public PlayerManagement pm;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Displays how many bombs the player has disarmed
    // Update is called once per frame
    void Update()
    {
        bombDisplay.text = "Bombs Disarmed = " + pm.bombsDisarmed.ToString() + "/" + bombsRemaining.ToString();
    }
}
