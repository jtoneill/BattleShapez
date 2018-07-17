using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCylinder : Player {

	// Use this for initialization
	void Start ()
    {

        Weapon weapon = gameObject.GetComponentInChildren(typeof(Weapon)) as Weapon;

        if (weapon != null)
        {
            weapon.shooter = transform;
        }


        anim = gameObject.GetComponentInChildren<Animator>();
        ps = GameController.FindObjectOfType<PlayerStats>();
        es = GameController.FindObjectOfType<EnemyStats>();

        myHealth = ps.healthCylinder;
        myAttackDamage = ps.damageCylinder;




    }
	
	// Update is called once per frame
	void Update ()
    {
        FindClosestEnemy();
        Guidance();
    }
}
