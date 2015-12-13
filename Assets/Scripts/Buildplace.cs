using UnityEngine;
using System.Collections;

public class Buildplace : MonoBehaviour {
    // The Tower that should be built
	public GameObject towerPrefab;
	public variableControl _varCont;

	void Start() {
		GameObject theGround = GameObject.Find("Ground");
		_varCont = theGround.GetComponent<variableControl>();
	}

	void OnMouseUpAsButton() {
		if (_varCont._timeyPoints >= _varCont._towerCost){
    	        // Build Tower above Buildplace
			GameObject towerInstance = (GameObject)Instantiate(towerPrefab);
			towerInstance.transform.position = transform.position + Vector3.up - new Vector3(0.5f,0,0.3f);
			_varCont._timeyPoints -= _varCont._towerCost;
		}
	}
}