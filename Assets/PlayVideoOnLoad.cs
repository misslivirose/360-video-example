using UnityEngine;
using System.Collections;

public class PlayVideoOnLoad : MonoBehaviour {
    public MovieTexture _movie;
	// Use this for initialization
	void Start () {
        _movie.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
