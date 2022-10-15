using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject Help;
    public GameObject baseK;
    bool basekIsEnabled;
    bool helpIsEnabled;
    
    public void PauseButton()
    {

        basekIsEnabled ^= true;
        baseK.SetActive(basekIsEnabled);
        
    }

    public void ResetButton()
    {
        SceneManager.LoadScene(0);
    }

    public void HelpButton()
    {
        helpIsEnabled ^= true;
        Help.SetActive(helpIsEnabled);
        
    }

    public void QuitButton()
    {
        Application.Quit();
    }

}
