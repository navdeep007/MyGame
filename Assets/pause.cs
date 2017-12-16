using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{

    public bool IsPaused;

  
    public GameObject PauseText;
    public GameObject PauseButton;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (IsPaused)
        {
           
            PauseText.SetActive(true);
            PauseButton.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            
            PauseText.SetActive(false);
            PauseButton.SetActive(false);
            Time.timeScale = 1f;
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
        }
    }
}