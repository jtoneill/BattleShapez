using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterBase : MonoBehaviour
{

    public Animator anim;
    public Transform mTarget;
    
    public int myHealth;
    public int myAttackDamage;

    public bool touching;

    //public float mSpeed = 3.0f;

    public PlayerStats ps;
    public EnemyStats es;



    public NavMeshAgent agent;

    public float EPSILON;

    // Use this for initialization
    void Start()
    {
       
    }



    // Update is called once per frame
    void Update()
    {


    }


    public void takeDamage(int hurts)
    {
      

        myHealth -= hurts;

        print(gameObject.name + "'s HP = " + myHealth);

        if (myHealth <= 0)
        {
            Die();

        }
    }
  

    public void Die()
    {
        if (gameObject.tag == "Enemy")
        {
            ps.expPoints();
        }
        Destroy(gameObject);
        print(gameObject.name + " dead");
    }





    public void Guidance()
    {
        transform.LookAt(mTarget.position);
        if ((transform.position - mTarget.position).magnitude >= EPSILON)
        {
            anim.SetInteger("AnimPar", 0);

            //transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
            //commented out above moves the character towards the closest opponent but does not account for obstructions to direct path

            //below, this uses the nav mesh agent AI to map out shortest path to opponent moving around obstructions
            agent.SetDestination(mTarget.position);

            //e1attacking = false;
            //untag the sword while walking by retagging it to 'untagged', wait, then re tag it back to E1Sword or E2Sword
            //that way the swords cant harm anyone while a character is walking
        }
        else
        {
            anim.SetInteger("AnimPar", 1);
            
        }
    }

    

   
}
