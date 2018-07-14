using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{



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

    public PlayerStats ps;
    public EnemyStats es;
    
    



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
            ps.bank += 2;
            es.Ebank += 2;
            currencyText.text = ps.bank.ToString();
            timer = 0;
        }
    }

    public void bankPurchase()
    {
        //refreshes the GUI currency amount after you make a purchase
        currencyText.text = ps.bank.ToString();
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
        cubeHP.text = ps.healthCube.ToString();
        cubeA.text = ps.damageCube.ToString();
        cubeS.text = ps.speedCube.ToString();
        cubeC.text = "$" + ps.costCube.ToString();
        print("CubeStatsUpdated");
    }

    public void updateSphereStats()
    {
        sphereHP.text = ps.healthSphere.ToString();
        sphereA.text = ps.damageSphere.ToString();
        sphereS.text = ps.speedSphere.ToString();
        sphereC.text = "$" + ps.costSphere.ToString();
        print("SphereStatsUpdated");
    }

    public void updateCylinderStats()
    {
        cylinderHP.text = ps.healthCylinder.ToString();
        cylinderA.text = ps.damageCylinder.ToString();
        cylinderS.text = ps.speedCylinder.ToString();
        cylinderC.text = "$" + ps.costCylinder.ToString();
        print("CylinderStatsUpdated");
    }

    public void updatePyramidStats()
    {
        pyramidHP.text = ps.healthPyramid.ToString();
        pyramidA.text = ps.damagePyramid.ToString();
        pyramidS.text = ps.speedPyramid.ToString();
        pyramidC.text = "$" + ps.costPyramid.ToString();
        print("PyramidStatsUpdated");
    }
    
}
