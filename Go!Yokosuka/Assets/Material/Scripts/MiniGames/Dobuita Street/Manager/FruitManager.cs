using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

// IVAN ROMERO MOYANO //

public class FruitManager : MonoBehaviour
{
    public static FruitManager instance;

    [SerializeField]
    private List<GameObject> fruitsPrefabs = new List<GameObject>();

    [SerializeField]
    private Canvas canvas;  // Ref a Canvas, asignado en el Inspector

    private void Awake()
    {
        SingletonPattern();
    }

    private void Start()
    {
        SpawnStartFruits();
    }

    void SpawnStartFruits()
    {
        for (int i = 0; i < 3; i++)
        {
            // Instanciamos el prefab, pero esta vez lo asignamos al Canvas
            GameObject fruit = Instantiate(getRandomFruit(), GetSpawnPosition(), Quaternion.identity);

            // Hacemos que el prefab sea hijo del Canvas
            fruit.transform.SetParent(canvas.transform, false);  // false mantiene las transformaciones locales

            // Si necesitas cambiar las propiedades del prefab, como el tamaño o la posición, hazlo aquí
            // fruit.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);  // Ejemplo para ajustar el tamaño
        }
    }

    private Vector3 GetSpawnPosition()
    {
        return new Vector3(Random.Range(ScreenHelper.ScreenLeft, ScreenHelper.ScreenRight),
                            ScreenHelper.ScreenTop + Random.Range(1, 3));
    }

    GameObject getRandomFruit()
    {
        return fruitsPrefabs[Random.Range(0, fruitsPrefabs.Count)];
    }

    private void SingletonPattern()
    {
        if (instance == null)
        {
            instance = this;

            // Asegúrate de que el objeto es un GameObject raíz y aplica DontDestroyOnLoad
            if (transform.parent == null)
            {
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                // Si el objeto tiene un padre, asegúrate de moverlo al nivel raíz
                transform.SetParent(null);
                DontDestroyOnLoad(gameObject);
            }
        }
        else if (instance != this)
        {
            Destroy(gameObject); // Destruye duplicados
        }
    }
}
