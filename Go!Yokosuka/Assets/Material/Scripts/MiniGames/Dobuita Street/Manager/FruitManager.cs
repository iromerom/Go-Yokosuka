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
    private List <GameObject> fruitsPrefabs = null;

    private void Awake()
    {
        SingletonPattern;
    }


    private void SingletonPattern()
    {
        if (instance == null)
        {
            instance == this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}
