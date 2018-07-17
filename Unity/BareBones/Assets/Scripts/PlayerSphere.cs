using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSphere : Player {

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

        myHealth = ps.healthSphere;
        myAttackDamage = ps.damageSphere;




    }
	
	// Update is called once per frame
	void Update ()
    {
        FindClosestEnemy();
        Guidance();
    }
}
