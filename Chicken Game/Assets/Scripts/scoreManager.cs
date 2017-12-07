using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoreManager : MonoBehaviour {

	public static int score;
	
	public int winScore;
	public Text text;
	public Text winText;
	public bool run = false;

	void Start () {
		winText.GetComponent<Text>().enabled = false;
		text = GetComponent<Text>();
		score = 0;
	}

	void Update () {
		if(score < 0)
			score = 0;

		text.text = " " + score;

		// If the player wins display win text
		if(winScore == score ){
			print("It worked! " + score);
			winText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}

		if(score >= 10){
			run = true;
		}

	}

	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}

	public static void SubtractPoints(int pointsToSubtract){
		score -= pointsToSubtract;
	}

	public void Reset() {
		score=0;
	}
}
