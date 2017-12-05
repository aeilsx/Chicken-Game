using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {
	public Transform brains;
	public float moveSpeed;
	void Update(){
		if(score <= 100){
			transform.LookAt(brains);
			transform.Translate(Vector3.back*-moveSpeed*Time.deltaTime);
		}
	}
}
