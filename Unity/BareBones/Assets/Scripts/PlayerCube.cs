using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCube : Player
{

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        //health = 60;
        //print("healthchange");
    }

    // Update is called once per frame
    void Update()
    {
        FindClosestEnemy();
        Guidance();
    }
}
