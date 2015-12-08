using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeyPUI : MonoBehaviour {
	public UnityEngine.UI.Text _timeyPoints;
	public variableControl _varCont;

 void Start() {
    	_timeyPoints = GetComponent<Text>();
    	GameObject theGround = GameObject.Find("Ground");
		_varCont = theGround.GetComponent<variableControl>();
		_timeyPoints.text = _varCont._timeyPoints.ToString();
	}

    void Update() {
    	_timeyPoints.text = _varCont._timeyPoints.ToString();
    }
}