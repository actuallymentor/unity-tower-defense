using UnityEngine;
using System.Collections;

public class dalekDamage : MonoBehaviour {
	public variableControl varCont;

	void Start() {
		GameObject theGround = GameObject.Find("Ground");
		varCont = theGround.GetComponent<variableControl>();
	}

	// Dalek reaches Tardis
	void OnTriggerEnter(Collider other) {

		if (other.gameObject.name == "Dalek(Clone)") {
			varCont.tardisDecrease(varCont.enemyDifficulty);
			Debug.Log ("Current health is " + varCont.tardisCurrent() );
			Destroy (other.gameObject);
		}
	}
}