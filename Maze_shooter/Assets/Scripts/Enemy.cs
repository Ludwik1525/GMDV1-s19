using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

    public Transform playerPos;

    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update () {
        navMeshAgent.destination = playerPos.position;
	}
}
