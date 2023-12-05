using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Adapted from SANDS ARTS, 2019. PlayerHealth.cs. N/A: SandS Arts.

public class ObstacleHitPoints : MonoBehaviour
{
    public float obstacleHitpoints = 3f;
    public AudioSource audioSourceBreak;
    public AudioClip Break;

    void Start()
    {

    }

    void Update()
    {

    }

    //If the player bullet hits the obstacle GameObject, the obstacle loses a hitpoint and plays a break sound effect, if it loses all hitpoints, the obstacle is destroyed
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "PlayerBullet")
        {
            audioSourceBreak.clip = Break;
            audioSourceBreak.Play();
            obstacleHitpoints -= 1f;
            Debug.Log(obstacleHitpoints);

            if (obstacleHitpoints <= 0)
            {
                
                Destroy(gameObject);
            }
        }
    }
}
