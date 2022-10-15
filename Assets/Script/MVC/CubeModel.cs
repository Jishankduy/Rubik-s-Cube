using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModel
{
    private CubeController CubeController;

    public CubeModel(float speed)
    {
        Speed = speed;


    }
    public float Speed { get; }




    public void SetCubeController(CubeController _cudeController)
    {
        CubeController = _cudeController;
    }
    

}
