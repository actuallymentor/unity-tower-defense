using UnityEngine;
using System.Collections;

public class dalekDamage : MonoBehaviour {
	public variableControl varCont;
	AudioSource _explosion;
	public ShakeCamera _cam;

	void Start() {
		GameObject theGround = GameObject.Find("Ground");
		GameObject _theCamera = GameObject.Find("Main Camera");
		varCont = theGround.GetComponent<variableControl>();
		_cam = _theCamera.GetComponent<ShakeCamera>();
		_explosion = GetComponent<AudioSource>();
	}

	void Update() {
		if (varCont.tardisCurrent() < 0) {
			Application.LoadLevel(3);
		}
	}

	// Dalek reaches Tardis
	void OnTriggerEnter(Collider other) {

		if (other.gameObject.name == "ActualDalek(Clone)") {
			varCont.tardisDecrease(varCont.enemyDifficulty);
			Debug.Log ("Current health is " + varCont.tardisCurrent() );
			_explosion.Play();
			_cam.Shake();
			Destroy (other.gameObject);
		}
	}

	// Camera shake


}