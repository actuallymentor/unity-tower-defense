using UnityEngine;
using System.Collections;

public class towerHealth : MonoBehaviour {
	public int TowerHealth = 100;
	public bool inPain = false;
	public int enemyDifficulty = 10;

	void Start() {
		InvokeRepeating("GetHurt", 1, 1.0F);
	}

	void Update() {
		if (TowerHealth < 0) {
			Destroy(gameObject);
		}
	}

	// Return the current Health
	public int current() {
		return TowerHealth;
	}

	// Decrease the current Health
	public void decrease(int damagedone) {
		TowerHealth = TowerHealth - damagedone;
	}

	// Be hurt
	public void GetHurt() {
		if (inPain) {
			decrease(enemyDifficulty);
			Debug.Log("Tower health is " + current());
		}
	}
	
	// Activate extermination at contact
	
	void OnTriggerEnter(Collider enemy) {
		if (enemy.gameObject.name == "Dalek(Clone)") {
			inPain = true;
		}
	}
	
	// Deactivate extermination at contact loss
	
	void OnTriggerExit(Collider enemy) {
		if (enemy.gameObject.name == "Dalek(Clone)") {
			inPain = false;
		}
	}

}