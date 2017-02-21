using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_ctrl : MonoBehaviour {
    private Vector2 velocity;

    public float smoothTimeX;
    public float smoothTimeY;
    public GameObject charac;

    public bool cam_bounds;
    public Vector3 min_cam_pos;
    public Vector3 max_cam_pos;

	// Use this for initialization
	void Start () {
        charac = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //camera follows player
        float pos_x = Mathf.SmoothDamp(transform.position.x, charac.transform.position.x, ref velocity.x, smoothTimeX);
        float pos_y = Mathf.SmoothDamp(transform.position.y, charac.transform.position.y, ref velocity.y, smoothTimeY);
        transform.position = new Vector3(pos_x, pos_y, transform.position.x);

        //limit camera bounds
        if (cam_bounds)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, min_cam_pos.x, max_cam_pos.x),Mathf.Clamp(transform.position.y, min_cam_pos.y, max_cam_pos.y), Mathf.Clamp(transform.position.z, min_cam_pos.z, max_cam_pos.z));
        }


    }
}
