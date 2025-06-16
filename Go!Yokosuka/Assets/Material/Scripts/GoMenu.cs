using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// IVAN ROMERO MOYANO //

public class GoMenu : MonoBehaviour
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
        if (count > 2f)
        {
            SceneManager.LoadScene(2);
            count = 0;
        }
    }
}
