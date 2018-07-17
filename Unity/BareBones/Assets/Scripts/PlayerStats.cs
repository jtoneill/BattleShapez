using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{



    public int bank = 0;

    public int levelingPoints = 2;

    public int campaignLevel;
    public int exp;
    public int nextLvlExp = 10;

    public Slider lvlUpBar;
    public Text currentLvlPause;

    public Slider gameplayExpBar;
    public Text currentLvlGameplay;

    //base stats - used for calculating final upgrade value
    public int healthCubeBase = 40;
    public int damageCubeBase = 10;
    public int speedCubeBase = 3;
    public int healthSphereBase = 30;
    public int damageSphereBase = 5;
    public int speedSphereBase = 3;
    public int healthCylinderBase = 200;
    public int damageCylinderBase = 15;
    public int speedCylinderBase = 2;
    public int healthPyramidBase = 400;
    public int damagePyramidBase = 5;
    public int speedPyramidBase = 1;





    //Cube (character 1)
    //stat1
    public int healthCube = 40;    
    //stat2
    public int damageCube = 10;    
    //stat3
    public int speedCube = 3;

    public int costCube = 2;
    
    public int hpLevelCube = 0;
    public int damageLevelCube = 0;
    public int speedLevelCube = 0;

    public int hpMultCube = 5;
    public int damageMultCube = 2;
    public int speedMultCube = 1;


    

    //Sphere (character 2)
    public int healthSphere = 30;
    public int damageSphere = 5;
    public int speedSphere = 3;

    public int costSphere = 10;
    
    public int hpLevelSphere = 0;
    public int damageLevelSphere = 0;
    public int speedLevelSphere = 0;

    public int hpMultSphere = 5;
    public int damageMultSphere = 2;
    public int speedMultSphere = 1;

    

    //Cylinder (character 3)
    public int healthCylinder = 200;
    public int damageCylinder = 15;
    public int speedCylinder = 2;

    public int costCylinder = 20;
    
    public int hpLevelCylinder = 0;
    public int damageLevelCylinder = 0;
    public int speedLevelCylinder = 0;

    public int hpMultCylinder = 5;
    public int damageMultCylinder = 4;
    public int speedMultCylinder = 1;

   

    //Pyramid (character 4)
    public int healthPyramid = 400;
    public int damagePyramid = 5;
    public int speedPyramid = 1;

    public int costPyramid = 40;
    
    public int hpLevelPyramid = 0;
    public int damageLevelPyramid = 0;
    public int speedLevelPyramid = 0;

    public int hpMultPyramid = 5;
    public int damageMultPyramid = 3;
    public int speedMultPyramid = 1;

    

    public int playerOrbHealth = 1000;
    

    public int character;


    public GameController gc;
 

    public Text expToGo;
    public Text lvlPointText;


    // Use this for initialization
    void Start ()
    {
        //linked to gc so we can call refresh functions for different text elements after upgrading.
        gc = GameController.FindObjectOfType<GameController>();


        lvlUpBar.value = exp;
        lvlUpBar.maxValue = nextLvlExp;
        currentLvlPause.text = "Campaign Level: " + campaignLevel.ToString();

        gameplayExpBar.value = exp;
        gameplayExpBar.maxValue = nextLvlExp;
        currentLvlGameplay.text = campaignLevel.ToString();

        expInfo();
        lvlPoint();
        
    }

    // Update is called once per frame
    void Update () {
		
	}



    //called in the die method in characterBase only if its an enemy character
    public void expPoints()
    {
        exp += 2;
        
        expInfo();

        if (exp >= nextLvlExp)
        {
            campaignLevel += 1;
            levelingPoints += 1;
            exp = 0;
            print("exp maxed: " + nextLvlExp);
            nextLvlExp = nextLvlExp + (nextLvlExp / 2);
            print("exp to next lvl: " + nextLvlExp);

            lvlUpBar.value = exp;
            lvlUpBar.maxValue = nextLvlExp;
            currentLvlPause.text = "Campaign Level: " + campaignLevel.ToString();
            currentLvlGameplay.text = campaignLevel.ToString();
            lvlPoint();
            expInfo();
        }

    }



    public void lvlPoint()
    {
        lvlPointText.text = "*" + levelingPoints;
    }

    public void expInfo()
    {
        lvlUpBar.value = exp;
        gameplayExpBar.value = exp;

        expToGo.text = "Exp.\n" + exp + " / " + nextLvlExp;
    }







    //These are called by the Pause Menu character buttons. They set the character variable which lets
    //... us know which character's stats to display in the pause menu for upgrading.
    public void setCharCube()
    {
        character = 1;
        Debug.Log("Cube Selected");
        gc.cubeUpgradeOffer();
    }

    public void setCharSphere()
    {
        character = 2;
        Debug.Log("Sphere Selected");
        gc.sphereUpgradeOffer();
    }

    public void setCharCylinder()
    {
        character = 3;
        Debug.Log("Cylinder Selected");
        gc.cylinderUpgradeOffer();
    }

    public void setCharPyramid()
    {
        character = 4;
        Debug.Log("Pyramid Selected");
        gc.pyramidUpgradeOffer();
    }

    //This function is called by the upgrade buttons. 
    //The 'stat' parameter(1-3) is set in unity at the OnClick connection for each button.
    //speed might level too fast, so maybe switch to floats somewhere at some point...
    public void UpgradeStat(int stat)
    {
        //check that you have enough levelingPoints for the selected upgrade
        if(levelingPoints >= 1)
        {


            if (character == 1)
            {
                if (stat == 1)
                {
                    hpLevelCube += 1;
                    healthCube = healthCubeBase + (hpLevelCube * hpMultCube);
                }
                else if (stat == 2)
                {
                    damageLevelCube += 1;
                    damageCube = damageCubeBase + (damageLevelCube * damageMultCube);
                }
                else if (stat == 3)
                {
                    speedLevelCube += 1;
                    speedCube = speedCubeBase + (speedLevelCube * speedMultCube);
                }

                //refreshes pause menu info
                gc.cubeUpgradeOffer();

                print("cube - HP: " + hpLevelCube + ", Attack: " + damageLevelCube + ", Speed: " + speedLevelCube);

                //subtract a leveling point for the purchase
                levelingPoints -= 1;
            }
            else if (character == 2)
            {
                if (stat == 1)
                {
                    hpLevelSphere += 1;
                    healthSphere = healthSphereBase + (hpLevelSphere * hpMultSphere);
                }
                else if (stat == 2)
                {
                    damageLevelSphere += 1;
                    damageSphere = damageSphereBase + (damageLevelSphere * damageMultSphere);
                }
                else if (stat == 3)
                {
                    speedLevelSphere += 1;
                    speedSphere = speedSphereBase + (speedLevelSphere * speedMultSphere);
                }

                gc.sphereUpgradeOffer();

                print("sphere - HP: " + hpLevelSphere + ", Attack: " + damageLevelSphere + ", Speed: " + speedLevelSphere);

                levelingPoints -= 1;
            }
            else if (character == 3)
            {
                if (stat == 1)
                {
                    hpLevelCylinder += 1;
                    healthCylinder = healthCylinderBase + (hpLevelCylinder * hpMultCylinder);
                }
                else if (stat == 2)
                {
                    damageLevelCylinder += 1;
                    damageCylinder = damageCylinderBase + (damageLevelCylinder * damageMultCylinder);
                }
                else if (stat == 3)
                {
                    speedLevelCylinder += 1;
                    speedCylinder = speedCylinderBase + (speedLevelCylinder * speedMultCylinder);
                }

                gc.cylinderUpgradeOffer();

                print("cylinder - HP: " + hpLevelCylinder + ", Attack: " + damageLevelCylinder + ", Speed: " + speedLevelCylinder);

                levelingPoints -= 1;
            }
            else if (character == 4)
            {
                if (stat == 1)
                {
                    hpLevelPyramid += 1;
                    healthPyramid = healthPyramidBase + (hpLevelPyramid * hpMultPyramid);
                }
                else if (stat == 2)
                {
                    damageLevelPyramid += 1;
                    damagePyramid = damagePyramidBase + (damageLevelPyramid * damageMultPyramid);
                }
                else if (stat == 3)
                {
                    speedLevelPyramid += 1;
                    speedPyramid = speedPyramidBase + (speedLevelPyramid * speedMultPyramid);
                }

                gc.pyramidUpgradeOffer();

                print("pyramid - HP: " + hpLevelPyramid + ", Attack: " + damageLevelPyramid + ", Speed: " + speedLevelPyramid);

                levelingPoints -= 1;
            }

            lvlPoint();

        }
        else
        {
            print("not enough levelingPoints");
        }
        

        

        
    }

   

}
