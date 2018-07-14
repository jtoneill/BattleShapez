using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CharacterBase
{
    

    // Use this for initialization
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "PCube" && touching == false)
        {
            print("EnemyHitByCube " + myHealth);
            takeDamage(ps.damageCube);
            touching = true;
            
        }
        else if (col.gameObject.tag == "PSphere" && touching == false)
        {
            print("EnemyHitBySphere " + myHealth);
            takeDamage(ps.damageSphere);
            touching = true;
        }
        else if (col.gameObject.tag == "PCylinder" && touching == false)
        {
            print("EnemyHitByCylinder " + myHealth);
            takeDamage(ps.damageCylinder);
            touching = true;
        }
        else if (col.gameObject.tag == "PPyramid" && touching == false)
        {
            print("EnemyHitByPyramid " + myHealth);
            takeDamage(ps.damagePyramid);
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

    // Update is called once per frame
    void Update()
    {
     

    }



    public void FindClosestPlayer()
    {
        float distanceToClosestPlayer = Mathf.Infinity;
        Player closestPlayer = null;
        Player[] allPlayers = GameObject.FindObjectsOfType<Player>();

        foreach (Player currentPlayer in allPlayers)
        {
            float distanceToPlayer = (currentPlayer.transform.position - this.transform.position).sqrMagnitude;
            if (distanceToPlayer < distanceToClosestPlayer)
            {
                distanceToClosestPlayer = distanceToPlayer;
                closestPlayer = currentPlayer;

            }
        }
        if (closestPlayer.transform.position != null && this.transform.position != null)
        {
            Debug.DrawLine(this.transform.position, closestPlayer.transform.position);
            mTarget = closestPlayer.transform;
        }

    }
}
