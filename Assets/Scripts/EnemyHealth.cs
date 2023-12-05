using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 3f;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "PlayerBullet")
        {
            enemyHealth -= 1f;
            Debug.Log(enemyHealth);

            if (enemyHealth <= 0)
            {
                Destroy(gameObject);
                
            }
        }
    }
}
