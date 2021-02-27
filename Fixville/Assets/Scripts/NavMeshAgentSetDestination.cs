using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentSetDestination : MonoBehaviour {

	NavMeshAgent navmeshAgent;

	void Start () {
		navmeshAgent = GetComponent<NavMeshAgent> ();
	}

	public void SetAgentDestinationTo (Vector3 pos) {
        navmeshAgent.destination = pos;
	}

}
