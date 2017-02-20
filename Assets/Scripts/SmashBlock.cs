using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashBlock : MonoBehaviour 
{
	void OnCollisionEnter(Collision hit)
	{
		if (hit.gameObject.name == "HitBlock") 
		{
			Debug.Log ("COLLISION", gameObject);
		}
	}
}
