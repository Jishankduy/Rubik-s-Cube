using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeService : SingletonGeneric<CubeService>
{ 
    public CubeView cubeView;
    /*public CubeController cubeController;
    public CubeViewList cubeViewList;
    public CubeScriptableObjectList CubeList;*/

    private void Start()
    {
        CubeModel model = new CubeModel(200f);
        CubeController cube = new CubeController(model, cubeView);

    }

    

}
