using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zombie : MonoBehaviour {
	public Transform brains;
	public float moveSpeed;
	public GameObject score;
	void Update(){
		// anotherScript = GetComponent<AnotherScript>();

		if(score.GetComponent<scoreManager>().run == true){
			print("Run");
			// transform.LookAt(brains);
			// transform.Translate(Vector3.back*-moveSpeed*Time.deltaTime);
		}
	}
}
