using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{   
    
    private GameObject hitSound;
    public AudioSource sound;
    public GameObject restart;
    public GameObject quit;
    public GameManager manager;
    void Start()
    {
        hitSound = GameObject.FindGameObjectWithTag("HitSound");
        sound = hitSound.GetComponent<AudioSource>();
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        
        if (manager.running){       //if running, trigger the button and play the hit sound
            if(other.tag == "Obstacle"||other.tag == "Ground"){
                Debug.Log("you hit something");
                if(!sound.isPlaying){
                    
                    Debug.Log("hit sound");
                    sound.Play();
                    restart.SetActive(true);
                    // restart.anchoredPosition = Vector3.zero;
                    quit.SetActive(true);
                    // quit.anchoredPosition = new Vector3(0f,-110.0f,0f);
                    
                }
            manager.running = false; //makes the previous commands not to be called again
        }}
        
    }
}
