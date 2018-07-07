using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterBase
{

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ECube")
        {
            print("PlayerHitByCube");
            //takeDamage(10);
        }
        else if (col.gameObject.tag == "E2Troll")
        {
            print("PlayerHitByTroll");
            //takeDamage(30);
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
