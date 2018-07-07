using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCube : Enemy
{

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        FindClosestPlayer();
        Guidance();
    }
}
