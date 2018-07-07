using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    //base stats

    //Cube
    public int healthCube = 40;
    public int damageCube = 10;
    public int speedCube = 3;
    public int costCube = 1;

    //Sphere
    public int healthSphere = 30;
    public int damageSphere = 10;
    public int speedSphere = 4;
    public int costSphere = 5;

    //Cylinder
    public int healthCylinder = 200;
    public int damageCylinder = 15;
    public int speedCylinder = 2;
    public int costCylinder = 15;

    //Pyramid
    public int healthPyramid = 100;
    public int damagePyramid = 40;
    public int speedPyramid = 1;
    public int costPyramid = 40;

    //references to text fields in the gui (drag and dropped)
    public Text cubeHP;
    public Text cubeA;
    public Text cubeS;
    public Text sphereHP;
    public Text sphereA;
    public Text sphereS;
    public Text cylinderHP;
    public Text cylinderA;
    public Text cylinderS;
    public Text pyramidHP;
    public Text pyramidA;
    public Text pyramidS;

    public Text cubeC;
    public Text sphereC;
    public Text cylinderC;
    public Text pyramidC;

    //Currency GUI text
    public Text currencyText;

    private float timer = 0f;
    public int bank = 0;



    // Use this for initialization
    void Start ()
    {
        updateStats();
    }
	
	// Update is called once per frame
	void Update ()
    {
        currencyCounter();
    }


    public void currencyCounter()
    {
        //updates each frame, Time.delatTime is the amount of time since the last frame. 
        //keep adding this passed time into 'timer' until it is more than say 2 seconds.
        //reset the timer and start over.
        timer += Time.deltaTime;
        if (timer > 2f)
        {
            bank += 2;
            currencyText.text = bank.ToString();
            timer = 0;
        }
    }

    public void bankPurchase()
    {
        //refreshes the GUI currency amount after you make a purchase
        currencyText.text = bank.ToString();
    }


    public void updateStats()
    {
        updateCubeStats();
        updateSphereStats();
        updateCylinderStats();
        updatePyramidStats();
    }

    public void updateCubeStats()
    {
        cubeHP.text = healthCube.ToString();
        cubeA.text = damageCube.ToString();
        cubeS.text = speedCube.ToString();
        cubeC.text = "$" + costCube.ToString();
        print("CubeStatsUpdated");
    }

    public void updateSphereStats()
    {
        sphereHP.text = healthSphere.ToString();
        sphereA.text = damageSphere.ToString();
        sphereS.text = speedSphere.ToString();
        sphereC.text = "$" + costSphere.ToString();
        print("SphereStatsUpdated");
    }

    public void updateCylinderStats()
    {
        cylinderHP.text = healthCylinder.ToString();
        cylinderA.text = damageCylinder.ToString();
        cylinderS.text = speedCylinder.ToString();
        cylinderC.text = "$" + costCylinder.ToString();
        print("CylinderStatsUpdated");
    }

    public void updatePyramidStats()
    {
        pyramidHP.text = healthPyramid.ToString();
        pyramidA.text = damagePyramid.ToString();
        pyramidS.text = speedPyramid.ToString();
        pyramidC.text = "$" + costPyramid.ToString();
        print("PyramidStatsUpdated");
    }
}
