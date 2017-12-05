using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenWander : MonoBehaviour {

	public float moveSpeed;
	public float countDown;

	void Start(){
		MoveForward();
		countDown = Random.Range(0.5f,3f);
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
			countDown = Random.Range(0.5f,3f);
			Turn();
			moveSpeed = Random.Range(2f,5f);
		}
		
	}

	// void OnTriggerStay(Collider other){
	// 	if(other.gameObject.tag ==	"CheckPoint"){
	// 		//transform.LookAt("CheckPoint");
	// 		Turn();
	// 	}
	// 	else{
	// 		MoveForward();
	// 	}
	// }

	//Trying to get the Checkpoint to move on it's own within a small area.
	//  void OnCollisionEnter(Collision other){
    //     if(other.gameObject.name == "Chicken"){
    //         transform.position = Random.Range(10,360);
    //     }
    // }
}
