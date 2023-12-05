using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//Adapted from TROASTER, 2021. shootingScript.cs. N/A: tRoaster.
//Adapted from JGN GAMES, 2018 . AmmoDisplay.cs. N/A: JGN Games.


public class AmmoDisplay : MonoBehaviour
{
    public int currentAmmo;
    public TextMeshProUGUI ammoDisplay;
    public string slash = "/";
    public int maxAmmo = 12;
    public float updateDelay;

    private bool isFiring = false;
    private float lastFireTime = 0f;
    public float fireDelay = 0.5f; // Adjust this value for the desired delay between shots

    // Start is called before the first frame update
    void Start()
    {
        // Initialize your ammo count and other values as needed.
    }

    // Update is called once per frame
    void Update()
    {
        //Displays ammo text
        ammoDisplay.text = "Ammo = " + currentAmmo.ToString() + slash + maxAmmo;

        //If mouse button 0 is pressed, when the gun is not firing and if the ammo is greater than 0, the ammo count will go down. Taking into account the firing delay
        if (Input.GetMouseButtonDown(0) && !isFiring && currentAmmo > 0 && Time.time - lastFireTime >= fireDelay)
        {
            isFiring = true;
            currentAmmo--;
            lastFireTime = Time.time;
            StartCoroutine(ResetFiringFlag());
        }
    }

    //Introduces a firing delay when the player has shot
    IEnumerator ResetFiringFlag()
    {
        yield return new WaitForSeconds(fireDelay);
        isFiring = false;
    }
}
