using UnityEngine;

public class CubeController
{
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
    Vector3 previousMousePosition;
    Vector3 mouseDelta;

    public CubeModel CubeModel { get; }
    public CubeView CubeView { get; }


    public CubeController(CubeModel cubeModel, CubeView CubePrefeb)
    {
        CubeModel = cubeModel;
        CubeView = GameObject.Instantiate<CubeView>(CubePrefeb);

        CubeView.SetCubeController(this);
        CubeModel.SetCubeController(this);
    }

    public void MouseButtonDown()
    {
        //get the 2D position of the first mouse click
        firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        CubeView.print(firstPressPos);
    }

    public void Swipe()
    {
        if (Input.GetMouseButtonDown(1))
        {
            //get the 2D position of the first mouse click
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            // print(firstPressPos);
        }
        if (Input.GetMouseButtonUp(1))
        {
            //get the 2D poitio of the Second mouse click
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            //create a Vactor from the first and seconf click positions
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
            //normalize the 2D vector
            currentSwipe.Normalize();

            if (LeftSwipe(currentSwipe))
            {
                CubeView.targest.transform.Rotate(0, 90, 0, Space.World);
            }
            else if (RightSwipe(currentSwipe))
            {
                CubeView.targest.transform.Rotate(0, -90, 0, Space.World);
            }

            else if (UpLeftSwipe(currentSwipe))
            {
                CubeView.targest.transform.Rotate(90, 0, 0, Space.World);
            }
            else if (UpRightSwipe(currentSwipe))
            {
                CubeView.targest.transform.Rotate(0, 0, -90, Space.World);
            }

            else if (DownLeftSwipe(currentSwipe))
            {
                CubeView.targest.transform.Rotate(0, 0, 90, Space.World);
            }
            else if (DownRightSwipe(currentSwipe))
            {
                CubeView.targest.transform.Rotate(-90, 0, 0, Space.World);
            }
        }
    }

    public void Drag()
    {
        if (Input.GetMouseButton(1))
        {
            // while the mouse is held down the cube can be moved around its central axis to provide visual feedback
            mouseDelta = Input.mousePosition - previousMousePosition;
            mouseDelta *= 0.1f; // reduction of rotation speed
            CubeView.transform.rotation = Quaternion.Euler(mouseDelta.y, -mouseDelta.x, 0) * CubeView.transform.rotation;
        }

        else
        {
            if (CubeView.transform.rotation != CubeView.targest.transform.rotation)
            {
                var step = CubeModel.Speed * Time.deltaTime;
                CubeView.transform.rotation = Quaternion.RotateTowards(CubeView.transform.rotation, CubeView.targest.transform.rotation, step);
            }
        }
        previousMousePosition = Input.mousePosition;
    }

    bool LeftSwipe(Vector2 swipe)
    {
        return currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f;
    }

    bool RightSwipe(Vector2 swipe)
    {
        return currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f;
    }

    bool UpLeftSwipe(Vector2 swipe)
    {
        return currentSwipe.y > 0 && currentSwipe.x < 0f;
    }

    bool UpRightSwipe(Vector2 swipe)
    {
        return currentSwipe.y > 0 && currentSwipe.x > 0f;
    }

    bool DownLeftSwipe(Vector2 swipe)
    {
        return currentSwipe.y < 0 && currentSwipe.x < 0f;
    }

    bool DownRightSwipe(Vector2 swipe)
    {
        return currentSwipe.y < 0 && currentSwipe.x > 0f;
    }


}
