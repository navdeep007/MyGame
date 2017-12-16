using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOADSCENE1 : MonoBehaviour {
    
public void Change(string SceneName)
    {
        
        SceneManager.LoadScene(SceneName);
    }
}
