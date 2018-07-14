using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCylinder : Player {

	// Use this for initialization
	void Start ()
    {

        anim = gameObject.GetComponentInChildren<Animator>();
        ps = GameController.FindObjectOfType<PlayerStats>();
        es = GameController.FindObjectOfType<EnemyStats>();

        myHealth = ps.healthCylinder;
        

        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        FindClosestEnemy();
        Guidance();
    }
}
