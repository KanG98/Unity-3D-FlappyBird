using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{   
    
    public float speed;
    
    

    // Update is called once per frame
    void Update(){   
        if(gameObject.tag == "Obstacle"){
            transform.Translate(Vector3.forward*speed*Time.deltaTime);}

    }

    

    // public void obsGenerator(){
    //     Instantiate(gameObject, new Vector3(35, 6.1, -2.5))
    // }
}
