using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

// IVAN ROMERO MOYANO //

public class SettingMenu : MonoBehaviour
{
    public Slider masterVol;                // Slider para controlar el volumen principal
    public AudioMixer mainAudioMixer;       // AudioMixer para ajustar el volumen
    public AudioSource musicSource;         // Fuente de audio de la música

    void Start()
    {
        if (masterVol != null)
        {
            masterVol.onValueChanged.AddListener(ChangeMasterVolume);
        }
    }

    public void ChangeMasterVolume(float volume)
    {
        if (mainAudioMixer != null)
        {
            mainAudioMixer.SetFloat("MasterVol", volume);
        }
        else
        {
            Debug.LogError("mainAudioMixer no está asignado.");
        }
    }


    public void ChangeMasterVolume()
    {
        if (mainAudioMixer != null && masterVol != null)
        {
            mainAudioMixer.SetFloat("MasterVol", masterVol.value);
        }
        else
        {
            Debug.LogError("mainAudioMixer or masterVol is not assigned in the inspector.");
        }
    }
}
