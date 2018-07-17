using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterBase
{


    

    // Use this for initialization
    void Start()
    {
        
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
