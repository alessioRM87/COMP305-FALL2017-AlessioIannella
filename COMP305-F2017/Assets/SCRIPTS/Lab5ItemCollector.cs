using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5ItemCollector : MonoBehaviour {

	public int BombCollected { get; set; }
	public int CoinCollected { get; set; }
	public int BoxCollected { get; set; }

	void Awake()
	{
		DontDestroyOnLoad (this.gameObject);
	}

	// Use this for initialization
	void Start () {
		BombCollected = 0;
		CoinCollected = 0;
		BoxCollected = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
