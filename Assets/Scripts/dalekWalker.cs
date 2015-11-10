using UnityEngine;
using System.Collections;

public class dalekWalker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NavMeshAgent dalekNavAgent = GetComponent<NavMeshAgent>();
		dalekNavAgent.destination = GameObject.Find ("Tardis").transform.position;
	}
}