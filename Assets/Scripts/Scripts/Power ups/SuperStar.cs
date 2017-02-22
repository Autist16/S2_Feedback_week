using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperStar : Collectible
{
    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        base.Update();
    }

    public override void OnTriggerEnter(Collider collider)
    {
        base.OnTriggerEnter(collider);
        Player player = collider.GetComponent<Player>();
        if (player != null)
        {
            player.Ability = player.gameObject.AddComponent<Invulnerable>();
        }
    }
}
