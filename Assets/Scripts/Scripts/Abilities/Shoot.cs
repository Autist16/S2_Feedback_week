using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Ability
{
    public GameObject Projectile;

    float cooldown = 0.25f;
    float cooldownTimer = 0f;
    bool canFire = true;
    // Use this for initialization
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        cooldownTimer += Time.deltaTime;
        if (cooldownTimer >= cooldown)
        {
            cooldownTimer = 0;
            canFire = true;
        }
        if (finished)
            Destroy(this);
    }

    public override void Activate()
    {
        if (canFire == false)
            return;

        GameObject projectile = Projectile;
        Instantiate(projectile, transform.position + gameObject.GetComponent<Player>().SpawnPoint, Quaternion.identity);

        canFire = false;
    }
}
