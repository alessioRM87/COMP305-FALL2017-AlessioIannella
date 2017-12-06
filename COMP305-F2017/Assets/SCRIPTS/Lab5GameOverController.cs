using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lab5GameOverController : MonoBehaviour {

    public Text textGameOver;
	public Text textCoins;
	public Text textBombs;
	public Text textBoxes;

	// Use this for initialization
	void Start () {

		Lab5ItemCollector collector = GameObject.Find ("CollectionResults").GetComponent<Lab5ItemCollector>();

		textCoins.text = "Coins: " + collector.CoinCollected;
		textBombs.text = "Bombs: " + collector.BombCollected;
		textBoxes.text = "Boxes: " + collector.BoxCollected;

    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
