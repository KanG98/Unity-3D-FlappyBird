using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBird : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float distanceX;
    public float distanceZ;

   
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {   
        
        gameObject.transform.position = player.position + new Vector3(-distanceX, 0, distanceZ);
        
        
    }
}
