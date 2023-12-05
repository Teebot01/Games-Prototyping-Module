using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform enemyfirePoint;
    public Transform player;
    public GameObject enemybulletprefab;
    private float shotCooldown;
    public float startShotCooldown;
    public float maxDetectionRange = 10f; // Adjust this to set the maximum range for line of sight
    private bool hasLineOfSight = true;

    // Start is called before the first frame update
    void Start()
    {
        shotCooldown = startShotCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasLineOfSight)
        {
            Shoot();

            Debug.Log("Shooting");
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = player.position - transform.position;
        RaycastHit2D ray = Physics2D.Raycast(transform.position, direction, maxDetectionRange);

        if (ray.collider != null)
        {
            hasLineOfSight = ray.collider.CompareTag("Player");
            if (hasLineOfSight)
            {
                Debug.DrawRay(transform.position, direction, Color.green);
            }
            else
            {
                Debug.DrawRay(transform.position, direction, Color.red);
            }
        }
        else
        {
            hasLineOfSight = false;
        }
    }

    public void Shoot()
    {
        Vector2 direction = player.position - transform.position;
        transform.up = direction;

        if (shotCooldown <= 0)
        {
            GameObject bullet = Instantiate(enemybulletprefab, enemyfirePoint.position, enemyfirePoint.rotation);
            shotCooldown = startShotCooldown;

            
        }
        else
        {
            shotCooldown -= Time.deltaTime;
        }
    }
}