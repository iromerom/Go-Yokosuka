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
    private const int targetY = -20;  // Este es el valor fijo que quieres para Y
    Vector3 target;  // Esta es la posición final del objeto

    private void Awake()
    {
        Reset();  // Llama al método Reset cuando el objeto se despierte
    }

    private void Reset()
    {
        // Obtiene la posición actual del objeto (transform.position)
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
        float step = 200f * Time.deltaTime;  // La velocidad del movimiento
        // Mueve el objeto hacia el objetivo (target) de manera suave
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}
