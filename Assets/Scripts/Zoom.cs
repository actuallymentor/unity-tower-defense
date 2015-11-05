using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour {

	private float zoomSpeed = 2.0f;
	
	void Update () {
		
		float scroll = Input.GetAxis("Mouse ScrollWheel");
		transform.Translate(scroll * zoomSpeed, scroll * zoomSpeed, 0, Space.World);
	}
}
