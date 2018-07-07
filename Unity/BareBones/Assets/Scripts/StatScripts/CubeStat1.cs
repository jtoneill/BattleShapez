using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeStat1 : MonoBehaviour {

    public static int cubeHealth = 0;
    Text hp;

	// Use this for initialization
	void Start ()
    {
        hp = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        hp.text = cubeHealth.ToString();
	}
}
