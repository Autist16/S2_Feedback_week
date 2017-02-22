using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splashscreen : MonoBehaviour {
	public bool game_playing =false;
	// Use this for initialization
	void Start () {
		Time.timeScale = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (!game_playing) {
			Time.timeScale = 0.0f;
		} else {
			Time.timeScale = 1.0f;
		}
	}
	public void start_game(){
		game_playing = !game_playing;
	}
}
