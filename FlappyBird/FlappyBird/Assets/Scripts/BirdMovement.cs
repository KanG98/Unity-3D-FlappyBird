using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{   
    public Rigidbody rb;
    public int force;
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("force added");
            
            rb.velocity = Vector3.up*force;
            sound.Play(); 
        
            
            
            // rb.AddForce(Vector3.up* force* Time.deltaTime);
            // transform.Translate(Vector3.up*force*Time.deltaTime);
        }

    }

}
