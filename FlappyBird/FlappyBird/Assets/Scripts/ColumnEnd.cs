using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnEnd : MonoBehaviour
{   
    public GameObject topColumn;
    public GameObject buttomColumn;
    // private Transform temp;
    void Start()
     {
        
    }
    

    void OnTriggerEnter(Collider other)
    {   
        if(other.tag == "Obstacle"){
            // topColumn.transform.position += Vector3.up * 0.1f;
            Debug.Log("end");
            Destroy(GameObject.FindGameObjectsWithTag("Obstacle")[0],2.5f);
            Destroy(GameObject.FindGameObjectsWithTag("Obstacle")[1],2.5f);
        }
        Instantiate(topColumn, topColumn.transform);
        Instantiate(buttomColumn, buttomColumn.transform);
        

    }
}
