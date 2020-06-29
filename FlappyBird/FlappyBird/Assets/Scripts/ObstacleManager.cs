using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{   
    
    public float speed;
    
            
    
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update(){   
        if(gameObject.tag == "Obstacle"){
            transform.Translate(Vector3.forward*speed*Time.deltaTime);}
            
        
    }
}
