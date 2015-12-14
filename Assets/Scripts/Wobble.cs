using UnityEngine;
using System.Collections;

public class Wobble : MonoBehaviour {

	public float spinSpeed = 10f;

	void Update () {
		transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
	}

}
