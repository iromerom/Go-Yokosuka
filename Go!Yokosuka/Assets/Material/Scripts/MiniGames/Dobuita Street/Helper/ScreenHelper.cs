using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

// IVAN ROMERO MOYANO //

public class ScreenHelper : MonoBehaviour
{
    public static float ScreenTop;   
    public static float ScreenLeft;  
    public static float ScreenRight; 

    private void Awake()
    {
        // Cálculo de la posición de la cámara
        Vector3 cameraPosition = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));

        // Asignar los valores a las variables estáticas
        ScreenTop = cameraPosition.y;
        ScreenLeft = cameraPosition.x - Camera.main.transform.localScale.x + 1.5f;
        ScreenRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0)).x - .5f;
    }
}
