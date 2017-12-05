using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfWander : MonoBehaviour {

	public float moveSpeed;
	public float countDown;

	void Start(){
		MoveForward();
		countDown = Random.Range(3f,5f);
	}

	void MoveForward(){
		transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
	}

	void Turn(){
		int randomNum = Random.Range(0,360);
		transform.Rotate(0,randomNum,0);
	}

	void Update(){
		countDown -= Time.deltaTime;
		MoveForward();
		if(countDown <= 0){
			countDown = Random.Range(3f,5f);
			Turn();
		}
	}
}
