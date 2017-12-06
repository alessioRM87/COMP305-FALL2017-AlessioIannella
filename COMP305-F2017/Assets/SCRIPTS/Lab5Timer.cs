using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5Timer : MonoBehaviour {

    public double leftTime = 30.0; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        leftTime -= Time.deltaTime;
	}
}
