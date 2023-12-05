using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelebrationSound : MonoBehaviour
{
    public AudioSource audiosourceCelebration;
    public AudioClip Celebration;
    // Start is called before the first frame update
    //Plays a celebration sound effect as soon as the scene loads
    void Start()
    {
        audiosourceCelebration.clip = Celebration;
        audiosourceCelebration.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
