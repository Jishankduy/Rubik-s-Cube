using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeView : MonoBehaviour
{
    private CubeController CubeController;
    public GameObject targest;

    
    private void Start()
    {
        targest = GameObject.Find("Targest");
    }
    void Update()
    {
        CubeController.Swipe();
        CubeController.Drag();
    }
    public void SetCubeController(CubeController _tankController)
    {
        CubeController = _tankController;
    }

   
}
