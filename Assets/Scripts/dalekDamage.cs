using UnityEngine;
using System.Collections;

public class dalekDamage : MonoBehaviour {
	private controlHealth controlhealth;

	void Awake() {
		// Get the tardis
		controlhealth = GetComponent<controlHealth>();
	}

	// Dalek reaches Tardis
	void OnTriggerEnter(Collider other) {

		if (other.gameObject.name == "Dalek(Clone)") {
			controlhealth.decrease(1);
			Debug.Log ("Current health is " + controlhealth.current() );
			Destroy (other.gameObject);
		}
	}
}