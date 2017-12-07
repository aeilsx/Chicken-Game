using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour {

	public Text loseText;

	public GameObject GameManager;

	void Start (){
		loseText.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		//If the player loses display lose text
		if(GameManager.GetComponent<playerHealth>().gameover == true){
			loseText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
		
	}
}
