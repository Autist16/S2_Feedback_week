using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splash : MonoBehaviour {
	public bool playing = false;
	// Use this for initialization
	void Start () {
		Time.timeScale = 0.0;
	}
	
	// Update is called once per frame
	void Update () {
		if (playing == true) {
			Time.timeScale = 1;
		} else {
			Time.timeScale = 0;
		}
	}
	public void StartGame()
	{
		playing = true;
	}
}
