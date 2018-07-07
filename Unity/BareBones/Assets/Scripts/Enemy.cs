using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CharacterBase
{

    // Use this for initialization
    void Start()
    {
        GoodGuy = false;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "PCube")
        {
            print("EnemyHit");
            //takeDamage(10);
        }
        else if (col.gameObject.tag == "E1Troll")
        {
            print("EnemyHitByTroll");
            //takeDamage(30);
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
