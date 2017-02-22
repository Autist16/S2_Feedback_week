using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    public Player player;
    public float duration = 5;
    public float timer = 0;

    protected bool finished = false;

    public virtual void Start()
    {
        player = GetComponent<Player>();
    }

    public virtual void Update()
    {
        timer += Time.deltaTime;
        if(timer >= duration)
        {
            finished = true;
        }
    }
    
    public virtual void Activate()
    {
        
    }
}
