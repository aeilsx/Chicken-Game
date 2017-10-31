using UnityEngine; 
using System.Collections; 

public class ChickenAI : MonoBehaviour { 
 
    public Rigidbody enemy;
    public float moveSpeed;
    public Transform target;
    public Transform chickenPen;
    public int points = 10;
    
   //Chicken run away trigger
    void OnTriggerStay(Collider other)
    {

        if(other.gameObject.name == "Player"){
            Debug.Log("Player has entered chickens trigger");
            transform.LookAt(target);
            transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
            }
    } 
    

    //Chicken random movement
    //void 

    //Chicken transport to pen
    void OnCollisionEnter(Collision other){
        if(other.gameObject.name == "Player"){
            //Add points to score
            scoreManager.AddPoints(points);
            transform.position = chickenPen.position;
            transform.rotation = chickenPen.rotation;
        }
    }
        
}
//spice it up