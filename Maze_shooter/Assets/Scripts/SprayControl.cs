using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayControl : MonoBehaviour {

    public GameObject spray;

    private GameObject tempSpray;

	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            tempSpray = GameObject.Instantiate(spray);
            tempSpray.transform.parent = transform;
            tempSpray.transform.localEulerAngles = new Vector3(175, 0, 0);
            tempSpray.transform.localPosition = new Vector3(0,0,0);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            GameObject.Destroy(tempSpray);
        }


    }
}
