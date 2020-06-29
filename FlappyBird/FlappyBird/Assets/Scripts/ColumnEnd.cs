using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnEnd : MonoBehaviour
{   
    public GameObject topColumn;
    public GameObject buttomColumn;
    public GameObject ScoreTrigger;


    public float distance;
    // private Transform temp;
    void Start()
     {
        
    }
    

    void OnTriggerEnter(Collider other)
    {   float rand = Random.Range(14,24);
        Vector3 newColumnTopPos = new Vector3(topColumn.transform.position.x, rand, topColumn.transform.position.z);
        Vector3 newColumnButtomPos = new Vector3(buttomColumn.transform.position.x, rand-distance, buttomColumn.transform.position.z);
        Vector3 newTriggerPos = new Vector3(buttomColumn.transform.position.x, rand-distance+10.75f, buttomColumn.transform.position.z);
        if(other.tag == "Obstacle"){
            // topColumn.transform.position += Vector3.up * 0.1f;
            Debug.Log("end");
            Destroy(GameObject.FindGameObjectsWithTag("Obstacle")[0],2.5f);
            Destroy(GameObject.FindGameObjectsWithTag("Obstacle")[1],2.5f);
            Destroy(GameObject.FindGameObjectWithTag("Finish"), 2.5f);    
        }
        
        Instantiate(topColumn, newColumnTopPos, Quaternion.identity);
        Instantiate(buttomColumn, newColumnButtomPos, Quaternion.identity);
        Instantiate(ScoreTrigger, newTriggerPos, Quaternion.identity);

        
        

    }
}
