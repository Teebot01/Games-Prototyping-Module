using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Adapted from BRACKEYS, 2019. PlayerMovement.cs. N/A: Brackeys.
//JAKE MAKES GAMES, 2021. TopDownMovement.cs. N/A: Jake Makes Games.

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Controls the player's movement through the w, a, s, d keys
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb2d.velocity = moveInput * moveSpeed;
    }
}
