using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowExtinguisherAnimation : MonoBehaviour {


    [SerializeField]
    GameObject spray;

    private Component spra;


    // Use this for initialization
    void Start ()
    {
        spray.SetActive(!gameObject.activeSelf);
        spra = GetComponent<Component>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log(spray.GetComponents<Component>());
            
        }

        
    }
}
