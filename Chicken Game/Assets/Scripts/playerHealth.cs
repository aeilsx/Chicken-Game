using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class playerHealth : MonoBehaviour {

	public const int maxHealth = 10;
	public int currentHealth = maxHealth;

	public Text hp;
	public Text maxHP;

	public bool gameover = false;

	
	void Update () {
		hp.text = currentHealth.ToString();
		maxHP.text = maxHealth.ToString();	
	}

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth<= 0){
			currentHealth = 0;
			gameover = true;
			print("You're Dead! GAME OVER!");
		}
	}
}
