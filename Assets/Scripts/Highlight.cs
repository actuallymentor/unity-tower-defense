using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {

	private Color startcolor;
	void OnMouseEnter()
	{
		startcolor = GetComponent<Renderer>().material.color;
		GetComponent<Renderer>().material.color = Color.white;
	}
	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = startcolor;
	}
}
