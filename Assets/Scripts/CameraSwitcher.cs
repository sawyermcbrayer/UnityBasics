using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{

    public Camera MainCamera;
    public Camera CameraClose;

    // Start is called before the first frame update
    void Start()
    {
        //Cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            MainCamera.enabled = true;
            CameraClose.enabled = false;
        }
        if (Input.GetKey("2"))
        {
            MainCamera.enabled = false;
            CameraClose.enabled = true;
        }
    }
}
