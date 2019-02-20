using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class RaycastingEnemyStun : MonoBehaviour {

	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 7f))
            {
                GameObject hitObj = hit.collider.gameObject;
                if (hitObj.CompareTag("Enemy"))
                {
                    hitObj.GetComponent<Enemy>().SlowDown();
                }
            }
        }
    }
}
