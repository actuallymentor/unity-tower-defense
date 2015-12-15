using UnityEngine;
using System.Collections;

public class SayExterminate : MonoBehaviour {
	AudioSource _exterminate;
	public float _speakingFrequency;

	// Use this for initialization
	void Start () {
		_exterminate = GetComponent<AudioSource>();
		_exterminate.pitch += Random.Range(-0.1F, 0.8F);
		_speakingFrequency = Random.Range(2F, 5F);
		_exterminate.PlayDelayed(_speakingFrequency);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
