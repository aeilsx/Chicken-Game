using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHealth : MonoBehaviour {

	public int currentHealth;
	public int maxHealth = 3;
	public Transform spawnpoint;
	public int points;

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0){
			//Keep score at zero
			currentHealth = 0;
			print("wolf is dead!");
			//Add points to score for killing wolf
			scoreManager.AddPoints(points);
			//Move wolf to spawn point
			transform.position = spawnpoint.position;
			transform.rotation = spawnpoint.rotation;
			//Reset wolf health
			currentHealth = maxHealth;
		}

	}

}
