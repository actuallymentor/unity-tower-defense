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
			towerInstance.transform.position = transform.position + new Vector3(0,1,1);
			_varCont._timeyPoints -= _varCont._towerCost;
		}
	}
}