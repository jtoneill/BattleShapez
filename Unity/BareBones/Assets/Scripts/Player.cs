using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterBase
{


    

    // Use this for initialization
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "ECube" && touching == false)
        {
            
            print("PlayerHitByCube " + myHealth);
            takeDamage(es.damageCube);
            touching = true;
        }
        else if (col.gameObject.tag == "ESphere" && touching == false)
        {
            print("PlayerHitBySphere " + myHealth);
            takeDamage(es.damageSphere);
            touching = true;
        }
        else if (col.gameObject.tag == "ECylinder" && touching == false)
        {
            print("PlayerHitByCylinder " + myHealth);
            takeDamage(es.damageCylinder);
            touching = true;
        }
        else if (col.gameObject.tag == "EPyramid" && touching == false)
        {
            print("PlayerHitByPyramid " + myHealth);
            takeDamage(es.damagePyramid);
            touching = true;
        }

    }

    void OnTriggerExit()
    {
        if(touching == true)
        {
            touching = false;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
      

    }


    public void FindClosestEnemy()
    {
        float distanceToClosestEnemy = Mathf.Infinity;
        Enemy closestEnemy = null;
        Enemy[] allEnemies = GameObject.FindObjectsOfType<Enemy>();

        foreach (Enemy currentEnemy in allEnemies)
        {
            float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceToClosestEnemy)
            {
                distanceToClosestEnemy = distanceToEnemy;
                closestEnemy = currentEnemy;

            }
        }
        if (closestEnemy.transform.position != null)
        {
            Debug.DrawLine(this.transform.position, closestEnemy.transform.position);
            mTarget = closestEnemy.transform;
        }
    }
}
