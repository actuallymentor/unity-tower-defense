using UnityEngine;
using System.Collections;

public class BlinkYellow : MonoBehaviour {
	public Color startcolor;

	// Use this for initialization
	void Start () {
		startcolor = GetComponent<Renderer>().material.color;
		GetComponent<Renderer>().material.color = Color.white;
		InvokeRepeating("RedBlink", 1, 0.5f);
		InvokeRepeating("YellowBlink", 1.5f, 0.5f);
	}

	void RedBlink() {
		GetComponent<Renderer>().material.color = Color.red;
	}
	
	void YellowBlink() {
		GetComponent<Renderer>().material.color = Color.yellow;
	}
}
