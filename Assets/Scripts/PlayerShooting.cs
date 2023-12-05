using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Adapted from CG SMOOTHIE, 2020. Gun.cs. N/A: CG Smoothie.
//Adapted from TROASTER, 2021. shootingScript.cs. N/A: tRoaster.
//Adapted from BRACKEYS, 2019. Shooting.cs. N/A: Brackeys.
//Adapted from BRACKEYS, 2019. Weapon.cs. N/A: Brackeys.
//Adapted from BMO, 2022. Weapon.cs. N/A: BMo.

public class PlayerShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float bulletCount = 10;
    public float shotDelay = 0.5f;
    public ParticleSystem muzzleFlash;
    public AudioSource audioSourceGunShot;
    public AudioClip gunShot;
    public AudioSource audioSourceNoAmmo;
    public AudioClip noAmmo;
    private float lastShotTime;

    // Update is called once per frame
    void Update()
    {
            //Executes code for when the player shoots, and when the player runs out of ammo
            if (Input.GetButtonDown("Fire1") && Time.time - lastShotTime >= shotDelay)
            {
                if (bulletCount > 0)
                {
                    Shoot();
                    lastShotTime = Time.time;
                }
                else
                {
                audioSourceNoAmmo.clip = noAmmo;
                audioSourceNoAmmo.Play();
            }
            }
        
    }

    //Function for instantiating and firing the bullet, along with sound effects for the gun
    void Shoot()
    {
        muzzleFlash.Play();

        audioSourceGunShot.clip = gunShot;
        audioSourceNoAmmo.Play();

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        bulletCount--; // Decrease bullet count after shooting

        if (bulletCount < 1)
        {
            // Handle out of ammo or other logic (e.g., play a sound).
        }
    }
}
