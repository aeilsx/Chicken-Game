﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Win : MonoBehaviour {

	public int winScore;
	public GameObject scoreManager;
	int currentScore;

	public Text winText;

	// Use this for initialization
	void Start () {
		winText.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		//currentScore = scoreManager.gameObject.GetComponentInChildren<scoreManager>().scoreAmount;
		//currentScore = scoreManager.scoreAmount;
		print("It worked! " + currentScore);

		if(winScore == currentScore ){
			
			winText.GetComponent<Text>().enabled = true;
		}

		
	}
}
