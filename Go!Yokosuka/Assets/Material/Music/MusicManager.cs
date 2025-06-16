using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

// IVAN ROMERO MOYANO //

public class MusicManager : MonoBehaviour
{
    public AudioSource musicSource;  // La fuente de audio que se va a usar para la m�sica de fondo
    public AudioClip musicClip;      // La m�sica que quieres reproducir

   
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

        // Si musicClip no est� asignado, mostramos un error
        if (musicClip == null)
        {
            Debug.LogError("No se ha asignado un AudioClip en MusicManager.");
        }
    }

    void PlayMusic()
    {
        // Solo intentamos reproducir la m�sica si ambas referencias est�n correctamente asignadas
        if (musicSource != null && musicClip != null)
        {
            musicSource.clip = musicClip;
            musicSource.loop = true;  // Hacer que la m�sica se repita
            musicSource.Play();
        }
        else
        {
            Debug.LogError("MusicSource o MusicClip no est�n asignados correctamente.");
        }
    }
}
