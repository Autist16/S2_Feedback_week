using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlower : Collectible {

    public GameObject projectile;
	// Use this for initialization
	public override void Start () {
        base.Start();
	}

    // Update is called once per frame
    public override void Update () {
        base.Update();
	}

    public override void OnTriggerEnter(Collider collider)
    {
        base.OnTriggerEnter(collider);
        Player player = collider.GetComponent<Player>();
        if (player != null)
        {
            player.Ability = player.gameObject.AddComponent<Shoot>();
            ((Shoot)player.Ability).Projectile = projectile;
        }
    }
}
