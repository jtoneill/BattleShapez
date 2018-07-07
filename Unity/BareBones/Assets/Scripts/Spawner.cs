using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] character;
    public Vector3 spawnValues;
    public GameController gc;

    public void onCharacterPurchase(int choice)
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));

        Instantiate(character[choice], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
        
    }

    public void purchaseCube()
    {
        if(gc.bank >= gc.costCube)
        {
            onCharacterPurchase(0);
            gc.bank -= gc.costCube;
            gc.bankPurchase();
            print("Purchased Cube");
        } else
        {
            print("Not enough funds!");
        }
        
    }

    public void purchaseSphere()
    {
        if(gc.bank >= gc.costSphere)
        {
            onCharacterPurchase(1);
            gc.bank -= gc.costSphere;
            gc.bankPurchase();
            print("Purchased Sphere");
        } else
        {
            print("Not enough funds!");
        }

    }

    public void purchaseCylinder()
    {
        if(gc.bank >= gc.costCylinder)
        {
            onCharacterPurchase(2);
            gc.bank -= gc.costCylinder;
            gc.bankPurchase();
            print("Purchased Cylinder");
        } else
        {
            print("Not enough funds!");
        }
        
    }

    public void purchasePyramid()
    {
        if(gc.bank >= gc.costPyramid)
        {
            onCharacterPurchase(3);
            gc.bank -= gc.costPyramid;
            gc.bankPurchase();
            print("Purchased Pyramid");
        } else
        {
            print("Not enough funds!");
        }
        
    }


    /*
        public GameObject[] enemies;
        public Vector3 spawnValues;
        public float spawnWait;
        public float spawnMostWait;
        public float spawnLeastWait;
        public float startWait;
        public bool stop;

        int randEnemy;

        void Start()
        {
            StartCoroutine(waitSpawner());
        }


        void Update()
        {
            spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
        }

        IEnumerator waitSpawner()
        {
            yield return new WaitForSeconds(startWait);

            while (!stop)
            {
                //randEnemy = Random.Range(0, 2);

                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));

                Instantiate(enemies[0], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                //instead of enemies[0] use enemies[randEnemy] when spawning more than one prefab
                //print("spawned"); 


                yield return new WaitForSeconds(spawnWait);
            }

        }
        */
}
