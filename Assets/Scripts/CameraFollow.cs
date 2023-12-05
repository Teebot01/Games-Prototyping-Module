using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//JAKE MAKES GAMES, 2021. SmoothCameraFollow.cs. N/A: Jake Makes Games.

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float damping;

    private Vector3 velocity = Vector3.zero;

    //Camera follows the player's movements
    private void FixedUpdate()
    {
        Vector3 movePosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);

    }
}
