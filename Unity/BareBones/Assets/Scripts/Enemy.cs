using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CharacterBase
{
    

    // Use this for initialization
    void Start()
    {
        
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
