using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject Help;
    public GameObject baseK;
    bool Menu; 
    //private Help button;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseButton()
    {
       if(Menu != true)
        {
            baseK.SetActive(false);
            Menu = true;
        }
       else
        {
            baseK.SetActive(true);
            Menu = false;
        }
        
    }

    public void ResetButton()
    {
        SceneManager.LoadScene(0);
    }

    public void HelpButton()
    {
        if (Menu != true)
        {
            Help.SetActive(false);
            Menu = true;
        }
        else
        {
            Help.SetActive(true);
            Menu = false;
        }
    }

    public void QuitButton()
    {
        Application.Quit();
    }

}
