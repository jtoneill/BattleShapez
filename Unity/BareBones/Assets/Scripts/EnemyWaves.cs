using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaves : MonoBehaviour {

   
    private float waitTime = 0;

    public GameObject[] enemyCharacter;

    public Vector3 spawnValues;
    public GameController gc;
    public PlayerStats ps;
    public EnemyStats es;
   

    public bool gamePaused;

    public int numToSpawn;
    public int pause;
    public int rand;

    // Use this for initialization
    void Start ()
    {
        ps = GameController.FindObjectOfType<PlayerStats>();
        es = GameController.FindObjectOfType<EnemyStats>();
        gc = GameController.FindObjectOfType<GameController>();
       
        StartCoroutine(Wave1());
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void onEnemyCharacterPurchase(int choice)
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));

        Instantiate(enemyCharacter[choice], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

    }


    void wait(int pause)
    {
        waitTime += Time.deltaTime;
        if (waitTime > pause)
        {
           
            waitTime = 0;
        }
    }

    
    public void purchaseEnemyCube()
    {
        if (es.Ebank >= es.costCube)
        {
            onEnemyCharacterPurchase(0);
            es.Ebank -= es.costCube;
            print("Enemy Purchased Cube");
        }
        else
        {
            print("Not enough funds!");
        }

    }

    public void purchaseEnemySphere()
    {
        if (es.Ebank >= es.costSphere)
        {
            onEnemyCharacterPurchase(1);
            es.Ebank -= es.costSphere;
            print("Purchased Sphere");
        }
        else
        {
            print("Not enough funds!");
        }

    }

    public void purchaseEnemyCylinder()
    {
        if (es.Ebank >= es.costCylinder)
        {
            onEnemyCharacterPurchase(2);
            es.Ebank -= es.costCylinder;
            print("Purchased Cylinder");
        }
        else
        {
            print("Not enough funds!");
        }

    }

    public void purchaseEnemyPyramid()
    {
        if (es.Ebank >= es.costPyramid)
        {
            onEnemyCharacterPurchase(3);
            es.Ebank -= es.costPyramid;
            print("Purchased Pyramid");
        }
        else
        {
            print("Not enough funds!");
        }

    }


    //Called at the end of each enemy wave, this function keeps the waves coming
    //chooses a random # between 1 and the number of waves, then starts corrisponding wave/co-routine
    public void randomWave()
    {
        rand = Random.Range(1, 5);

        if(rand == 1)
        {
            StartCoroutine(Wave1());
        }
        else if(rand == 2)
        {
            StartCoroutine(Wave2());
        }
        else if (rand == 3)
        {
            StartCoroutine(Wave3());
        }
        else if (rand == 4)
        {
            StartCoroutine(Wave4());
        }
        else if (rand == 5)
        {
            StartCoroutine(Wave5());
        }
        else if (rand == 6)
        {
            StartCoroutine(Wave6());
        }
    }

    //purchases enemy character x number of times. where x is based on numToSpawn
    public void purchaseEnemy(int chosen)
    {
        if (chosen == 0)
        {
            while (numToSpawn > 0)
            {
                purchaseEnemyCube();
                numToSpawn--;
            }
        }
        else if (chosen == 1)
        {
            while (numToSpawn > 0)
            {
                purchaseEnemySphere();
                numToSpawn--;
            }
        }
        else if (chosen == 2)
        {
            while (numToSpawn > 0)
            {
                purchaseEnemyCylinder();
                numToSpawn--;
            }
        }
        else if (chosen == 3)
        {
            while (numToSpawn > 0)
            {
                purchaseEnemyPyramid();
                numToSpawn--;
            }
        }
    }


    public void pauseTrue()
    {
        gamePaused = true;
    }

    public void pauseFalse()
    {
        gamePaused = false;
    }

    public void PauseCheck()
    {
        
    }

    IEnumerator Wave1()
    {

        print("wave1");

        while (gamePaused)
        {
            yield return null;
        }


        //Random number of cubes spawned (2-4)
        numToSpawn = Random.Range(2, 4);
        print("numToSpawnCubes: " + numToSpawn);
        pause = numToSpawn * 3;
        //waits until there is enough funds, then buys/spawns enemy characters
        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(0);

        while (gamePaused)
        {
            yield return null;
        }

        numToSpawn = Random.Range(2, 3);
        print("numToSpawnSpheres: " + numToSpawn);
        pause = numToSpawn * 11;

        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(1);

        randomWave();

    }


    IEnumerator Wave2()
    {

        print("wave2");

        while (gamePaused)
        {
            yield return null;
        }

        numToSpawn = Random.Range(1, 2);
        print("numToSpawnCylinders: " + numToSpawn);
        pause = numToSpawn * 21;

        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(2);


        while (gamePaused)
        {
            yield return null;
        }


        numToSpawn = Random.Range(3, 4);
        print("numToSpawnCubes: " + numToSpawn);
        pause = numToSpawn * 3;

        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(0);


        while (gamePaused)
        {
            yield return null;
        }


        numToSpawn = Random.Range(2, 4);
        print("numToSpawnSpheres: " + numToSpawn);
        pause = numToSpawn * 11;

        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(1);

        randomWave();

    }

    IEnumerator Wave3()
    {

        print("wave3");

        
        numToSpawn = 1;
        print("numToSpawnPyramid: " + numToSpawn);
        pause = numToSpawn * 42;
        
        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(3);


        while (gamePaused)
        {
            yield return null;
        }

        numToSpawn = Random.Range(3, 4);
        print("numToSpawnCubes: " + numToSpawn);
        pause = numToSpawn * 3;

        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(0);


        while (gamePaused)
        {
            yield return null;
        }

        numToSpawn = Random.Range(3, 4);
        print("numToSpawnCubes: " + numToSpawn);
        pause = numToSpawn * 11;

        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(0);


        while (gamePaused)
        {
            yield return null;
        }

        numToSpawn = Random.Range(3, 4);
        print("numToSpawnSpheres: " + numToSpawn);
        pause = numToSpawn * 11;

        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(1);

        randomWave();

    }

    IEnumerator Wave4()
    {

        print("wave4");

        while (gamePaused)
        {
            yield return null;
        }

        numToSpawn = Random.Range(3, 5);
        print("numToSpawnCubes: " + numToSpawn);
        pause = numToSpawn * 3;

        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(0);


        randomWave();

    }

    IEnumerator Wave5()
    {

        print("wave5");

        while (gamePaused)
        {
            yield return null;
        }

        numToSpawn = Random.Range(3, 4);
        print("numToSpawnSpheres: " + numToSpawn);
        pause = numToSpawn * 11;

        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(1);


        randomWave();

    }

    IEnumerator Wave6()
    {

        print("wave6");

        while (gamePaused)
        {
            yield return null;
        }

        numToSpawn = 1;
        print("numToSpawnPyramid: " + numToSpawn);
        pause = numToSpawn * 41;

        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(3);


        StartCoroutine(Wave4());

    }

    IEnumerator Wave7()
    {

        print("wave7");

        while (gamePaused)
        {
            yield return null;
        }

        numToSpawn = Random.Range(1, 2); ;
        print("numToSpawnCylinder: " + numToSpawn);
        pause = numToSpawn * 21;

        print(Time.time + " waiting for " + pause + " seconds");
        yield return new WaitForSecondsRealtime(pause);
        print(Time.time + " done");
        purchaseEnemy(2);


        StartCoroutine(Wave4());

    }






}
