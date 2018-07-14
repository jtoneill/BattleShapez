using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPyramid : Enemy {

	// Use this for initialization
	void Start ()
    {

        anim = gameObject.GetComponentInChildren<Animator>();
        ps = GameController.FindObjectOfType<PlayerStats>();
        es = GameController.FindObjectOfType<EnemyStats>();

        myHealth = es.healthPyramid;
        

        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        FindClosestPlayer();
        Guidance();
    }
}
