using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I coped this code from youtube.com/watch?v=z7eojB_1wKg

public class InputManager : MonoBehaviour
{
    CameraOrbit cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<CameraOrbit>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.LeftArrow))
        {
            Debug.Log("Left Arrow was pressed.");
            cam.MoveHorizontal (true);
        }
        else if (Input.GetKeyDown (KeyCode.RightArrow))
        {
            Debug.Log("Right Arrow was pressed.");
            cam.MoveHorizontal (false);
        }
    
    }
}
