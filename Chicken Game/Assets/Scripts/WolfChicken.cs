using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfChicken : MonoBehaviour {

    //public Rigidbody enemy;
    public float moveSpeed;

    public Transform prey;

    public int damage;

    public GameObject pcHealth;
    
   
   //Chase Scripts
    void OnTriggerStay(Collider other)
    {

        //Chase the chicken
        if(other.gameObject.name == "Chicken"){
			//Debug.Log("Chicken has entered wolfs trigger");
            transform.LookAt(prey);
            transform.Translate(Vector3.back*-moveSpeed*Time.deltaTime);
            }
			
    } 

    //Wolf damage script
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Player"){
            var hit = other.gameObject;
            var health = hit.GetComponent<playerHealth>();
            print("Wolf is attacking!");

            if(pcHealth != null){
                
                pcHealth.gameObject.GetComponent<playerHealth>().TakeDamage(damage);
            }

        }

    }
   
        
}
