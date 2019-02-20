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

    public void SlowDown()
    {
        StartCoroutine(SlowDownRoutine());
    }

    IEnumerator SlowDownRoutine()
    {
        navMeshAgent.speed = 0;
        yield return new WaitForSeconds(5);
        navMeshAgent.speed = 3.5f;
    }
}
