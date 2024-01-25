using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumenSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider myMusicSlider;
    [SerializeField] private Slider mySfxSlider;


    private void Start()
    {

        if (PlayerPrefs.HasKey("musicVolumen"))
        {
            LoadVolumen();
        }
        else 
        {
            SetMusicVolumen();
        }

        
    }


    public void SetMusicVolumen() 
    {
        float volumen = myMusicSlider.value;
        myMixer.SetFloat("Music",Mathf.Log10(volumen)*20);
        PlayerPrefs.SetFloat("musicVolumen",volumen);
    }

    private void LoadVolumen() 
    {
        myMusicSlider.value = PlayerPrefs.GetFloat("musicVolumen");

        SetMusicVolumen();
    
    }
}
