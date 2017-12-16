using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{

    public void PlayButton(string SceneName)
    {
        SceneManager.LoadScene("home");
    }

   
}