using UnityEngine;

public class SpawnController : MonoBehaviour {
	
	public GameObject dalekPrefab;
	public static bool spawningDaleks = true;
	public variableControl varCont;

	void Start () {
		GameObject theGround = GameObject.Find("Ground");
		varCont = theGround.GetComponent<variableControl>();
		InvokeRepeating("SpawnCycle", varCont.spawnSpeed, 5.0F);
	}
	
	void SpawnCycle() {
		if (spawningDaleks) {
			if (Random.value < varCont.spawnDifficulty) {
				Debug.Log ("Spawned | Diff: " + varCont.spawnDifficulty);
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