using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool running = true;
    private AudioSource bgSound;
    public static int scoreInit= 0;

    public Text scoreBoard;
    
    void Start()
    {
        bgSound = GetComponent<AudioSource>();
        scoreBoard.text = scoreInit.ToString();
    }
    void Update()
    {
        if(running && !bgSound.isPlaying){  // !isPlaying checks if the sound, if not, plays the bgSound
            bgSound.Play();
        }
        scoreBoard.text = scoreInit.ToString();
    }
    public void Restart(){
        scoreInit = 0;
        running = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
