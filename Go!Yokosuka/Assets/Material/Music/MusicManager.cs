using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

// IVAN ROMERO MOYANO //

public class MusicManager : MonoBehaviour
{
    public AudioSource musicSource;  // La fuente de audio que se va a usar para la música de fondo
    public AudioClip musicClip;      // La música que quieres reproducir

   
    private static MusicManager instance;

    void Awake()
    {
       
        if (instance != null && instance != this)
        {
            Destroy(gameObject);  // Destruye el objeto duplicado 
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // No destruirlo al cambiar de escena
            PlayMusic();  
        }
    }

    void Start()
    {
        // Comprobamos si no se ha asignado el AudioSource desde el Inspector
        if (musicSource == null)
        {
            musicSource = GetComponent<AudioSource>();
        }

        // Si musicSource no se encuentra, mostramos un error
        if (musicSource == null)
        {
            Debug.LogError("No se ha asignado un AudioSource en MusicManager.");
        }

        // Si musicClip no está asignado, mostramos un error
        if (musicClip == null)
        {
            Debug.LogError("No se ha asignado un AudioClip en MusicManager.");
        }
    }

    void PlayMusic()
    {
        // Solo intentamos reproducir la música si ambas referencias están correctamente asignadas
        if (musicSource != null && musicClip != null)
        {
            musicSource.clip = musicClip;
            musicSource.loop = true;  // Hacer que la música se repita
            musicSource.Play();
        }
        else
        {
            Debug.LogError("MusicSource o MusicClip no están asignados correctamente.");
        }
    }
}
