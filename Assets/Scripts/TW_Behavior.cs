using UnityEngine;

public class TW_Behavior : MonoBehaviour {
	public bool _hasHit = false;

	// Send the timey wimey on its way
	void Start () {
		NavMeshAgent twNavAgent = GetComponent<NavMeshAgent>();
		twNavAgent.destination = GameObject.Find ("Dalek Home").transform.position;
	}

	void OnTriggerEnter(Collider other) {
		bool hasTriggered = false;
		if (other.gameObject.name == "Dalek Home") {
			Destroy (gameObject);
		}
		if (other.gameObject.name == "Dalek(Clone)" && !hasTriggered) {
			Destroy (other.gameObject);
			hasTriggered = true;
		}
	}


}