using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthUI : MonoBehaviour {
    public variableControl _varCont;
    public UnityEngine.UI.Text health;

    void Start() {
    	health = GetComponent<Text>();
    	GameObject theGround = GameObject.Find("Ground");
		_varCont = theGround.GetComponent<variableControl>();
		health.text = _varCont.TardisHealth.ToString();
    }

    void Update() {
    	health.text = _varCont.TardisHealth.ToString();
    }

}
