using UnityEngine;
using System.Collections;

public class variableControl : MonoBehaviour {

	
	//						//
	// DALEK SPAWN CONTROL
	//						//

	public float spawnDifficulty = 0.5f; // Determines spawn speed, between 0 and 1
	public int enemyDifficulty = 10; // Used in tower
	public float spawnSpeed = 1; // Run SpawnCycle every x seconds

	//					//
	// TARDIS HEALTH CONTROL
	//					//

	public int TardisHealth = 100;

	public int tardisCurrent() { // Return the current Health
		return TardisHealth;
	}

	public void tardisDecrease(int damagedone) { // Decrease the current Health
		TardisHealth = TardisHealth - damagedone;
	}

	//						//
	// WIBBLY TOWER CONTROL
	//						//
	
	public int TowerHealth = 100;


}
