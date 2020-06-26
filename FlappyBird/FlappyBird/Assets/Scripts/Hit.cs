using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{   
    public GameManager manager;
    private GameObject hitSound;
    public AudioSource sound;
    void Start()
    {
        hitSound = GameObject.FindGameObjectWithTag("HitSound");
        sound = hitSound.GetComponent<AudioSource>();
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle"||other.tag == "Ground"){
            Debug.Log("you hit something");
            if(!sound.isPlaying){
                Debug.Log("hit sound");
                sound.Play();
              }
            
            manager.Restart();  //comment it while testing
        }
    }
}
