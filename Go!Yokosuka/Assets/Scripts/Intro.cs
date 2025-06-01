using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// IVAN ROMERO MOYANO //

public class Intro : MonoBehaviour
{
    public float count;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count > 1.5f)
        {
            SceneManager.LoadScene(1);
            count = 0;
        }
    }
}
