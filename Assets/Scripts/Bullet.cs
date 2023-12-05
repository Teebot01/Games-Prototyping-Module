using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Tells the bullet to delete itself when it hits certain GameObjects
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Bomb")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Door")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }



    }
}
