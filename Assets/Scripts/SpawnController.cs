using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {
	
	public GameObject dalekPrefab;
	public static bool spawningDaleks = true;
	public float spawnDifficulty = 0.5f;

	void Start () {
		InvokeRepeating("SpawnCycle", 1, 1.0F);
		SpawnCycle ();
	}
	
	void SpawnCycle() {
		if (spawningDaleks) {
			if (Random.value < spawnDifficulty) {
				// Debug.Log ("Spawned | Diff: " + spawnDifficulty);
				SpawnDalek ();
			}
		}
	}


	void SpawnDalek() {
		GameObject dalekInstance = (GameObject)Instantiate (dalekPrefab);
		dalekInstance.transform.position = transform.position + Vector3.up;
	}

	void StartSpawn() {
		spawningDaleks = true;
	}
	
	void StopSpawn() {
		spawningDaleks = false;
	}
}