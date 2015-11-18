using UnityEngine;
using System.Collections;

public class towerHealth : MonoBehaviour {
	public bool inPain = false;
	public variableControl varCont;


	void Start() {
		GameObject theGround = GameObject.Find("Ground");
		varCont = theGround.GetComponent<variableControl>();
		InvokeRepeating("GetHurt", 1, 1.0F);
	}


	public int current() { // Return the current Health
		return varCont.TowerHealth;
	}
	
	public void decrease(int damagedone) { // Decrease the current Health
		varCont.TowerHealth = varCont.TowerHealth - damagedone;
	}


	public void GetHurt() { // Be hurt
		if (inPain) {
			decrease(varCont.enemyDifficulty);
			Debug.Log("Tower health is " + current());
		}
	}
	
	void OnTriggerEnter(Collider enemy) { // Activate extermination at contact
		if (enemy.gameObject.name == "Dalek(Clone)") {
			inPain = true;
		}
	}

	
	void OnTriggerExit(Collider enemy) { // Deactivate extermination at contact loss
		if (enemy.gameObject.name == "Dalek(Clone)") {
			inPain = false;
		}
	}

}