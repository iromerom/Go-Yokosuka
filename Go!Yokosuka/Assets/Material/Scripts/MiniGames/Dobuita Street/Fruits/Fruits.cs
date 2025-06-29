using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

// IVAN ROMERO MOYANO //


public class Fruits : MonoBehaviour
{
    private const float targetY = -20f;  // Este es el valor fijo que quieres para Y
    private Vector3 target;  // Esta es la posici�n final del objeto
    private float moveSpeed = 5f;  // Controla la velocidad de movimiento

    private void Awake()
    {
        Reset();  // Llama al m�todo Reset cuando el objeto se despierte
    }

    private void Reset()
    {
        // Obtiene la posici�n actual del objeto (transform.position)
        target = transform.position;

        // Cambia solo la componente Y, dejando X y Z igual que antes
        target = new Vector3(target.x, targetY, target.z);
    }

    void Update()
    {
        MoveDown();  // Llama a MoveDown en cada frame
    }

    private void MoveDown()
    {
        float step = moveSpeed * Time.deltaTime;  // La velocidad del movimiento
        // Mueve el objeto hacia el objetivo (target) de manera suave
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}
