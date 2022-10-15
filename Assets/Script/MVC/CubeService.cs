using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeService : SingletonGeneric<CubeService>
{ 
    public CubeView cubeView;

    private void Start()
    {
        CubeModel model = new CubeModel(200f);
        CubeController cube = new CubeController(model, cubeView);

    }

    

}
