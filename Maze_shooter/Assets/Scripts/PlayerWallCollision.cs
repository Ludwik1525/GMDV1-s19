using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallCollision : MonoBehaviour {

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        rb.angularVelocity = Vector3.zero;
    }

    private void OnCollisionStay(Collision collision)
    {
        rb.angularVelocity = Vector3.zero;
    }
}
}
