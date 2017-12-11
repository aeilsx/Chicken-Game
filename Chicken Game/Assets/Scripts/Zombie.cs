using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zombie : MonoBehaviour {
	public Transform brains;
	public float moveSpeed;
	public GameObject score;
	public GameObject pcHealth;
	public int damage;
	void Update(){
		// anotherScript = GetComponent<AnotherScript>();

		if(score.GetComponent<scoreManager>().run == true){
			print("Run");
			
			transform.LookAt(brains);
			transform.Translate(Vector3.back*-moveSpeed*Time.deltaTime);
		}
	}

	void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Player"){
            var hit = other.gameObject;
            var health = hit.GetComponent<playerHealth>();
            print("Zombie is attacking!");

            if(pcHealth != null){
                
                pcHealth.gameObject.GetComponent<playerHealth>().TakeDamage(damage);
            }

        }

    }
}
