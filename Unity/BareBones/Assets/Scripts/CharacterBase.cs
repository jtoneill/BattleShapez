using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterBase : MonoBehaviour
{

    public Animator anim;
    public Transform mTarget;

    public float mSpeed = 3.0f;
    public float EPSILON = 3.0f;
    
    public bool e1attacking = false;
    public bool e2attacking = false;
    public bool GoodGuy = true;

    public NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {

    }

    public void friendFoe()
    {

    }
    /*
    public void takeDamage(int hurts)
    {
        health -= hurts;

        if (health <= 0)
        {
            Die();

        }
    }
    */

    public void Die()
    {
        Destroy(gameObject);
        print("dead");
    }



    // Update is called once per frame
    void Update()
    {

        if (GoodGuy == true)
        {
            FindClosestEnemy();
        }
        else
        {
            FindClosestPlayer();
        }






    }

    public void Guidance()
    {
        transform.LookAt(mTarget.position);
        if ((transform.position - mTarget.position).magnitude >= EPSILON)
        {
            anim.SetInteger("AnimPar", 0);
            //transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
            agent.SetDestination(mTarget.position);
            e1attacking = false;
            //untag the sword while walking by retagging it to 'untagged', wait, then re tag it back to E1Sword or E2Sword
            //that way the swords cant harm anyone while a character is walking
        }
        else
        {
            anim.SetInteger("AnimPar", 1);
            e1attacking = true;
        }
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
