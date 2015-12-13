using UnityEngine;
using System.Collections;

public class TardisExplodes : MonoBehaviour {
	MovieTexture movie;

    // Use this for initialization
    void Start () {
        movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
        GetComponent<AudioSource>().clip = movie.audioClip;
        GetComponent<AudioSource>().Play();
        movie.Play();
    }

    // Update is called once per frame
    void Update () {
        if (!movie.isPlaying) {
            Debug.Log("Movie done");
            Application.LoadLevel(0);
        }
    }
}
