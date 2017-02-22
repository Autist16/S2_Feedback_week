using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

    public float Bounce = 5.0f;
    public float Speed = 5.0f;
    public float DestroyTimer = 0.0f;

    Rigidbody rigidBody;
	// Use this for initialization
	void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rigidBody.velocity = new Vector3(Speed, rigidBody.velocity.y);
	}

    public virtual void OnCollisionEnter(Collision col)
    {
        GameObject gameObject = col.gameObject;
        
        if (gameObject != null)
        {
            if(col.gameObject.tag == "Projectile")
            {
                Physics.IgnoreCollision(this.GetComponent<Collider>(), col.collider);
                return;
            }

            if (gameObject.tag == "Ground")
            {
                rigidBody.velocity = new  Vector3(rigidBody.velocity.x, Bounce);
            }
            else if (gameObject.tag == "Enemy")
            {
                Destroy(gameObject, DestroyTimer);
                //Destroy(this.gameObject, DestroyTimer);
            }
            else
                Destroy(this.gameObject, DestroyTimer);
        }
    }
}
