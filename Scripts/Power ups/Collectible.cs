using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    public float DestroyTimer = 0.0f;
    BoxCollider _collider;
    public bool HasCollided = false;
    // Use this for initialization
    public virtual void Start ()
    {
        _collider = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	public virtual void Update ()
    {
        if(HasCollided)
            Destroy(this.gameObject, DestroyTimer);
    }

    public virtual void OnTriggerEnter(Collider collider)
    {
        Player player = collider.GetComponent<Player>();
        if (player != null)
        {
            HasCollided = true;
        }
        else HasCollided = false;
    }
}
