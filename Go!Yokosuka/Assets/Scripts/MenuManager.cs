using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// IVAN ROMERO MOYANO //

public class MenuManager : MonoBehaviour
{
    public void Update()
    {
        // Si pulsamos la tecla "Esc" podemos volver a la escena previa //

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(2);
        }
    }

    ///////////////////////////////////////////
    // Empezar Partida //
    public void Play()
    {
        SceneManager.LoadScene(5);

    }
   
    // Acceder al menu de Opciones //
    public void Options()
    {
        SceneManager.LoadScene(3);
    }

    // Acceder la escena de Creditos //
    public void Credits()
    {
        SceneManager.LoadScene(4);
    }

    // Salir del juego //
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Se ha salido del juego");
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(2);

    }
}
