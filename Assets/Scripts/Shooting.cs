using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Adapted from CG SMOOTHIE, 2020. Gun.cs. N/A: CG SMOOTHIE.
//Adapted from TROASTER, 2021. shootingScript.cs. N/A: TROASTER.
//Adapted from BRACKEYS, 2019. Shooting.cs. N/A: BRACKEYS.
//Adapted from BRACKEYS, 2019. Weapon.cs. N/A: BRACKEYS.

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public int currentAmmo, maxAmmo = 12;
    public float firerate;
    float nextfire;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }
    void Shoot()
    {
        if (currentAmmo > 0)
        {
            if (Time.time > nextfire)
            {
                nextfire = Time.time + firerate;

                GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
                currentAmmo--;
            }
            
        }
    }
}

