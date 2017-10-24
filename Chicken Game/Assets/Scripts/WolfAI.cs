using UnityEngine; 
using System.Collections; 

public class WolfAI: MonoBehaviour { 
 
    public Rigidbody enemy;
    public float moveSpeed;
    public Transform target;
    
   
    void OnTriggerStay(Collider other)
    {

        if(other.gameObject.name == "Player"){
            Debug.Log("Player has entered wolfs trigger");
            transform.LookAt(target);
            transform.Translate(Vector3.back*-moveSpeed*Time.deltaTime);
            }
    } 
        
}
