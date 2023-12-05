using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 3f;
    public Slider healthSlider;

    void Start()
    {

    }

    void Update()
    {
        healthSlider.value = playerHealth;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            playerHealth -= 1f;
            Debug.Log(playerHealth);

            if (playerHealth <= 0)
            {
                Destroy(gameObject);
                TakePlayerBackToMainMenu();
            }
        }
    }

    private void TakePlayerBackToMainMenu()
    {
        SceneManager.LoadScene("GameMainMenu");
    }
}


