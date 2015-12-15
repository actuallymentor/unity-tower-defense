using UnityEngine;
using System.Collections;

public class towerHealth : MonoBehaviour {
	public bool inPain = false;
	public variableControl varCont;
	public int _towerHealth;
	public Collider _theDalek;

	void Start() {
		GameObject theGround = GameObject.Find("Ground");
		varCont = theGround.GetComponent<variableControl>();
		_towerHealth = varCont.TowerHealth;
	}

	void Update() {
		if (_towerHealth < 0) {
			//Destroy(gameObject);
			Destroy(transform.parent.gameObject);
		}
		if (!_theDalek && inPain) {
            CancelInvoke("ShootTimeyWimey");
            inPain = false;
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
			Debug.Log("Health: Dalek detected");
			_theDalek = enemy;
			if (!inPain) {
				Debug.Log("Enable PAIN invoke");
				InvokeRepeating("GetHurt", 0, 1.0F);
			}
			inPain = true;
		}
	}

	
	void OnTriggerExit(Collider enemy) { // Deactivate extermination at contact loss
		if (enemy.gameObject.name == "ActualDalek(Clone)") {
			Debug.Log("Health: Dalek gone");
			CancelInvoke("GetHurt");
			inPain = false;
		}
	}

}