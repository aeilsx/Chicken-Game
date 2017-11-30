using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenHealth : MonoBehaviour {

	public int currentHealth;
	public int maxHealth = 2;
	public Transform spawnpoint;
	public int points;

	void Start (){
		currentHealth = maxHealth;
	}

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0){
			//Keep score at zero
			currentHealth = 0;
			print("Chicken is dead!");
			//Add points to score for killing wolf
			scoreManager.SubtractPoints(points);
			//Move Chicken to spawn point
			transform.position = spawnpoint.position;
			transform.rotation = spawnpoint.rotation;
			//Reset Chicken health
			currentHealth = maxHealth;
		}

	}

}
