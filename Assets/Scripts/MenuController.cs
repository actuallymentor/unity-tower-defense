using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {
	public bool _isStart;
	void OnMouseUp(){ 
		switch(_isStart) {
			case true:
			Application.LoadLevel(1);
			break;
			case false:
			Application.Quit();
			break;
		}
	} 
}
