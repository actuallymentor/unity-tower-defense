using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	int TardisHealth = 100;

	// Use this for initialization
	void Start() {
	}

    // Update is called once per frame
	void Update() {

	}

// Return the current Health
	public int current() {
		return TardisHealth;
	}

// Decrease the current Health
	public void decrease(int damagedone) {
		TardisHealth = TardisHealth - damagedone;
	}

}
