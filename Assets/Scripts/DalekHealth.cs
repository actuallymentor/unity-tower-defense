using UnityEngine;

public class DalekHealth : MonoBehaviour {
	public int _dalekInstanceHealth;
	public variableControl _varCont;

	void Start() {
		GameObject theGround = GameObject.Find("Ground");
		_varCont = theGround.GetComponent<variableControl>();
		_dalekInstanceHealth = _varCont.dalekHealth;
	}

	void Update() {
		if (_dalekInstanceHealth < 0) {
			Destroy(gameObject);
			_varCont.spawnDifficulty += 0.01f;
			_varCont._timeyPoints += _varCont._pointsPerDalek;
		}
	}

}