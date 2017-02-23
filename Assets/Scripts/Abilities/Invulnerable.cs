using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invulnerable : Ability {

	// Use this for initialization
	public override void Start ()
    {
        base.Start();
	}

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        if (finished)
        {
            // player continue to take damage
            player.TakeDamage = true;
            Destroy(this);
        }
        else // player can not take damage
            player.TakeDamage = false;
    }
}
