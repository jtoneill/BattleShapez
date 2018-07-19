using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCylinder : Enemy {

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

        myHealth = es.healthCylinder;
        myAttackDamage = es.damageCylinder;

        mySpeed = es.speedCylinder;
        agent.speed = mySpeed;




    }

    // Update is called once per frame
    void Update ()
    {
        FindClosestPlayer();
        Guidance();
    }
}
