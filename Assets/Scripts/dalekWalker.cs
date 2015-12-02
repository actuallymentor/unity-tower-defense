using UnityEngine;
using System.Collections;

public class dalekWalker : MonoBehaviour {
	public variableControl _varCont;


	// Use this for initialization
	void Start () {
		NavMeshAgent dalekNavAgent = GetComponent<NavMeshAgent>();
		dalekNavAgent.destination = GameObject.Find ("Tardis").transform.position;
		GameObject theGround = GameObject.Find("Ground");
		_varCont = theGround.GetComponent<variableControl>();
		dalekNavAgent.speed = _varCont._dalekSpeed;
	}
}