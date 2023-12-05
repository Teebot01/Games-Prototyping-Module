using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
//Adapted from REHOPE GAMES, 2023. VolumeSettings.cs. N/A: Rehope Games.

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;

    private void Start()
    {
        //If the data for "MasterVoulme has been stored, run the "LoadVolume" method, if not run the "SetVolume" method
        if(PlayerPrefs.HasKey("MasterVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetVolume();
        }   
    }

    //Gets the slider value and sets the value of the audiomixer to the slider's value
    public void SetVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("MasterVolume", Mathf.Log10(volume)*20);
        
        //Stores the value of the slider
        PlayerPrefs.SetFloat("MasterVolume", volume);
    }

    private void LoadVolume()
    {
        //Slider value equals the "MasterVolume" keyname
        musicSlider.value = PlayerPrefs.GetFloat("MasterVolume");

        SetVolume();
    }
}
