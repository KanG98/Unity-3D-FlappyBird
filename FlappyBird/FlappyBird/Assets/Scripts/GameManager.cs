using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool running = true;
    private AudioSource bgSound;
    
    void Start()
    {
        bgSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(running && !bgSound.isPlaying){  // !isPlaying checks if the sound, if not, plays the bgSound
            bgSound.Play();
        }
    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
