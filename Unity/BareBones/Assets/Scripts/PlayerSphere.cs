using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSphere : Player {

	// Use this for initialization
	void Start ()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        FindClosestEnemy();
        Guidance();
    }
}
