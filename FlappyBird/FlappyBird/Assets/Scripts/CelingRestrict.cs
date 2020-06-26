using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelingRestrict : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform birdPosition;
    

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, birdPosition.transform.position)<=9){

        }
    }
}
