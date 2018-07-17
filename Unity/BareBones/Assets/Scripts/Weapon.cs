using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public PlayerStats ps;
    public EnemyStats es;
    public int myAttackDamage;

    public bool touching = false;
    public Transform shooter;

    // Use this for initialization
    void Start ()
    {
        ps = GameController.FindObjectOfType<PlayerStats>();
        es = GameController.FindObjectOfType<EnemyStats>();
       
       


        if (gameObject.tag == "CubeWeaponP")
        {
            myAttackDamage = ps.damageCube;
        }
        else if (gameObject.tag == "SphereWeaponP")
        {
            myAttackDamage = ps.damageSphere;
        }
        else if (gameObject.tag == "CylinderWeaponP")
        {
            myAttackDamage = ps.damageCylinder;
        }
        else if (gameObject.tag == "PyramidWeaponP")
        {
            myAttackDamage = ps.damagePyramid;
        }
        else if (gameObject.tag == "CubeWeaponE")
        {
            myAttackDamage = es.damageCube;
        }
        else if (gameObject.tag == "SphereWeaponE")
        {
            myAttackDamage = es.damageSphere;
        }
        else if (gameObject.tag == "CylinderWeaponE")
        {
            myAttackDamage = es.damageCylinder;
        }
        else if (gameObject.tag == "PyramidWeaponE")
        {
            myAttackDamage = es.damagePyramid;
        }
    }


   
	// Update is called once per frame
	void Update () {
		
	}



    //
    public void OnTriggerEnter(Collider col)
    {
        if (touching == false && col.gameObject.tag != shooter.tag)
        {
            col.gameObject.SendMessage("takeDamage", myAttackDamage);

            print(gameObject.tag + " dealt " + myAttackDamage + " damage to " + col.gameObject.name);

            touching = true;
        }
    }

    void OnTriggerExit()
    {
        if (touching == true)
        {
            touching = false;
        }
    }



}
