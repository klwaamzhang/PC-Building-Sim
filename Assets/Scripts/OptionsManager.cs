using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    private AudioSource musicSource;

    public AudioMixer audioMixer;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    // For the options panel, go to IntroPanelController

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetMusic(float music)
    {
        audioMixer.SetFloat("music", music);
    }

    public void SetSoundEffects(float soundEffects)
    {
        audioMixer.SetFloat("soundEffects", soundEffects);
    }
}
