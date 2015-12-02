using UnityEngine;
using System.Collections;

public class MenuHover : MonoBehaviour {

	private Color startcolor;

	void Start() {
		startcolor = GetComponent<TextMesh>().color;
	}
	void OnMouseEnter()	{		
		GetComponent<TextMesh>().color = Color.white;
	}
	void OnMouseExit()	{
		GetComponent<TextMesh>().color = startcolor;
	}
}
