using System.Collections;
using UnityEngine;

public class Pause : MonoBehaviour {
    public GameObject pause_screen;
    private bool paused = false;

	// Use this for initialization
	void Start () {
        pause_screen.SetActive(false);
        paused = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }
        
        if (paused)
        {
            pause_screen.SetActive(true);
            Time.timeScale = 0;
        }
        if (!paused)
        {
            pause_screen.SetActive(false);
            Time.timeScale = 1;
        }

    }
    public void Restart_level()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void Quit_Game(){
        Application.Quit();
    }
}
