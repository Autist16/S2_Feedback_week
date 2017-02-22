using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splash : MonoBehaviour {
	public bool playing = false;
	// Use this for initialization
	void Start () {
		Time.timeScale = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (playing == true) {
			Time.timeScale = 1.0f;
		} else {
			Time.timeScale = 0.0f;
		}
	}
	public void StartGame()
	{
		playing = true;
	}
}
