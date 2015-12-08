using UnityEngine;
using System.Collections;

public class variableControl : MonoBehaviour {

	
	//						//
	// DALEK SPAWN CONTROL
	//						//

	public float spawnDifficulty = 0.01f; // Determines spawn speed, between 0 and 1
	public int enemyDifficulty = 10; // Used in tower
	public float spawnSpeed = 10; // Run SpawnCycle every x seconds

	//						//
	// DALEK CONTROL
	//						//

	public int dalekHealth = 100;
	public float _dalekSpeed = 0.8f;

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
	public float WT_FireRate = 1; // Defined in seconds

	//						//
	// TIMEY CONTROL
	//						//
	public int _timeyPower = 30;
	public int _timeySpeed = 30;

	//					//
	// TIMEY POINTS CONTROL
	//					//
	public int _timeyPoints = 10;
	public int _pointsPerDalek = 10;
	public int _towerCost = 10;

}
