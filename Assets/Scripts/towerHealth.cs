using UnityEngine;
using System.Collections;

public class towerHealth : MonoBehaviour {
	public bool inPain = false;
	public variableControl varCont;
	public int _towerHealth;


	void Start() {
		GameObject theGround = GameObject.Find("Ground");
		varCont = theGround.GetComponent<variableControl>();
		_towerHealth = varCont.TowerHealth;
		InvokeRepeating("GetHurt", 1, 1.0F);
	}

	void Update() {
		if (_towerHealth < 0) {
			Destroy(gameObject);
		}
	}


	public int current() { // Return the current Health
		return _towerHealth;
	}
	
	public void decrease(int damagedone) { // Decrease the current Health
		_towerHealth -= damagedone;
	}


	public void GetHurt() { // Be hurt
		if (inPain) {
			decrease(varCont.enemyDifficulty);
			Debug.Log("Tower health is " + current());
		}
	}
	
	void OnTriggerEnter(Collider enemy) { // Activate extermination at contact
		if (enemy.gameObject.name == "ActualDalek(Clone)") {
			inPain = true;
		}
	}

	
	void OnTriggerExit(Collider enemy) { // Deactivate extermination at contact loss
		if (enemy.gameObject.name == "ActualDalek(Clone)") {
			inPain = false;
		}
	}

}