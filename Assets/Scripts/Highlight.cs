using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private Color startcolor;
	void OnMouseEnter()
	{
		startcolor = GetComponent<Renderer>().material.color;
		GetComponent<Renderer>().material.color = Color.yellow;
	}
	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = startcolor;
	}
}
