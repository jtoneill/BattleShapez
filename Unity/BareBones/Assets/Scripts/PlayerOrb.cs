using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrb : Player {



	// Use this for initialization
	void Start ()
    {
        ps = GameController.FindObjectOfType<PlayerStats>();
        es = GameController.FindObjectOfType<EnemyStats>();

        myHealth = ps.playerOrbHealth;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
