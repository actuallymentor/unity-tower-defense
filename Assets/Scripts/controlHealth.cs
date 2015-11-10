using UnityEngine;
using System.Collections;

public class controlHealth : MonoBehaviour {
	public int TardisHealth = 100;

// Return the current Health
	public int current() {
		return TardisHealth;
	}

// Decrease the current Health
	public void decrease(int damagedone) {
		TardisHealth = TardisHealth - damagedone;
	}

}
