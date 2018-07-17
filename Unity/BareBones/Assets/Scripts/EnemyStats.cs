using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int Ebank = 0;

    //base stats

    //Cube
    public int healthCube = 40;
    public int damageCube = 10;
    public int speedCube = 3;
    public int costCube = 2;

    //Sphere
    public int healthSphere = 30;
    public int damageSphere = 5;
    public int speedSphere = 3;
    public int costSphere = 10;

    //Cylinder
    public int healthCylinder = 200;
    public int damageCylinder = 15;
    public int speedCylinder = 2;
    public int costCylinder = 20;

    //Pyramid
    public int healthPyramid = 400;
    public int damagePyramid = 5;
    public int speedPyramid = 1;
    public int costPyramid = 40;

    public int enemyOrbHealth = 1000;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
