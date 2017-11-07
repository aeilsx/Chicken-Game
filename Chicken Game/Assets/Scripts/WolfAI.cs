using UnityEngine.UI; 
using System.Collections; 
using UnityEngine;

public class WolfAI: MonoBehaviour { 
 
    //public Rigidbody enemy;
    public float moveSpeed;
    public Transform target;
    public Transform prey;

    public int damage;
    
   
   //Chase Scripts
    void OnTriggerStay(Collider other)
    {
        //Chase the player
        if(other.gameObject.name == "Player"){
            Debug.Log("Player has entered wolfs trigger");
            transform.LookAt(target);
            transform.Translate(Vector3.back*-moveSpeed*Time.deltaTime);
            }

        //Chase the chicken
        if(other.gameObject.name == "Chicken"){
            Debug.Log("Chicken has entered wolfs trigger");
            transform.LookAt(prey);
            transform.Translate(Vector3.back*-moveSpeed*Time.deltaTime);
            }
    } 

    // ***NOT WORKING***
    //Wolf damage script
    // void OnCollisionEnter(Collision other)
    // {
    //     if(other.gameObject.name == "Player"){
    //         playerHealth.TakeDamage(damage);
        
    //     }


    //     print("Wolf is attacking!");
    //     var hit = other.gameObject;
    //     var health = hit.GetComponent<playerHealth>();

    //     if(health != null){
    //         health.TakeDamage(damage);
    //     }

    // }
   
        
}
