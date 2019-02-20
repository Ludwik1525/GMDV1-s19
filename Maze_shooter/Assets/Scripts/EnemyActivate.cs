using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActivate : MonoBehaviour {

    [SerializeField]
    GameObject enemy1;
    [SerializeField]
    GameObject enemy2;

    void Start () {

        enemy1.SetActive(false);
        enemy2.SetActive(false);
    }

    bool areActive = false;

    void OnTriggerEnter(Collider collider)
    {
        if (!areActive)
        {
            areActive = true;
            enemy1.SetActive(true);
            enemy2.SetActive(true);
        }
    }
}
