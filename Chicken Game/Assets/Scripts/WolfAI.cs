﻿using UnityEngine.UI; 
using System.Collections; 
using UnityEngine;

public class WolfAI: MonoBehaviour { 
 
    //public Rigidbody enemy;
    public float moveSpeed;
    public Transform target;
    public int damage;

    public GameObject pcHealth;
    
   
   //Chase Script
    void OnTriggerStay(Collider other)
    {
        //Chase the player
        if(other.gameObject.name == "Player"){
            Debug.Log("Player has entered wolfs trigger");
            transform.LookAt(target);
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
