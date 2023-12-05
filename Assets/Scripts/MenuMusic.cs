using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    public AudioSource audioSourceMusic;
    public AudioClip music;

    // Start is called before the first frame update
    //Plays music asset on application startup
    void Start()
    {
        audioSourceMusic.clip = music;
        audioSourceMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
