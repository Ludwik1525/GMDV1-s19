using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour {

    public Camera mainCamera;
    public Camera frontCamera;

    void Start()
    {
        frontCamera.enabled = false;
        mainCamera.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            mainCamera.enabled = !mainCamera.enabled;
            frontCamera.enabled = !frontCamera.enabled;
        }
    }


}
