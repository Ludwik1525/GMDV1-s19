using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_Trigger : MonoBehaviour {

    [SerializeField]
    GameObject leftDoor;
    [SerializeField]
    GameObject rightDoor;

    private int count = 0;

    bool isOpen = false;

    void OnTriggerEnter(Collider collider)
    {
        if(!isOpen)
        {
            isOpen = true;
            leftDoor.transform.Rotate(0, 90, 0);
            leftDoor.transform.localPosition -= new Vector3(0.0176f, 0.01667f, 0);
            rightDoor.transform.Rotate(0, -90, 0);
            rightDoor.transform.localPosition += new Vector3(0.018436f, -0.01757f, 0);
            count++;
            Debug.Log(count);
        }
    }
}
