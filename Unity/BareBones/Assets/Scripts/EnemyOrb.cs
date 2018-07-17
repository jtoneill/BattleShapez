using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrb : Enemy {

	// Use this for initialization
	void Start ()
    {
        ps = GameController.FindObjectOfType<PlayerStats>();
        es = GameController.FindObjectOfType<EnemyStats>();

        myHealth = es.enemyOrbHealth;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
