using UnityEngine;

public class TW_Behavior : MonoBehaviour {
	public variableControl _varCont;
	public float thrust;



	// Send the timey wimey on its way
	void Start () {
		GameObject theGround = GameObject.Find("Ground");
		_varCont = theGround.GetComponent<variableControl>();
		thrust = _varCont._timeySpeed;
	}

	void FixedUpdate () {
		gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 1, ForceMode.Force);
	}

	void OnTriggerEnter(Collider other) {
		switch (other.gameObject.name) {
			case "ActualDalek(Clone)":
			other.gameObject.GetComponent<DalekHealth>()._dalekInstanceHealth -= _varCont._timeyPower;
			Debug.Log("Dalek collide" + other + other.gameObject.GetComponent<DalekHealth>()._dalekInstanceHealth);
			Destroy (gameObject);
			break;
			case "Black Hole":
			Destroy (gameObject);
			break;
			case "WibblyWobbly(Clone)":
			Debug.Log("WW Detected");
			break;
		}
	}
}