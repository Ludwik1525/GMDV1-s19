using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_Trigger : MonoBehaviour {

    [SerializeField]
    GameObject leftDoor;
    [SerializeField]
    GameObject rightDoor;

    bool isOpen = false;

    void OnTriggerEnter(Collider collider)
    {
        if(!isOpen)
        {
            isOpen = true;
            leftDoor.transform.Rotate(90, 0, 0);
            leftDoor.transform.position -= new Vector3(0.0176f, 0.01667f, 0);
            rightDoor.transform.Rotate(-90, 0, 0);
            rightDoor.transform.position += new Vector3(0.046436f, -0.01757f, 0);
        }
    }
}
