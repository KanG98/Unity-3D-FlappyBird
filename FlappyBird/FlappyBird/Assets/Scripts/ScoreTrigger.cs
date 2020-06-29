using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreTrigger : MonoBehaviour
{

    private GameObject scoretrigger;
    public Text score;
    public int speed;
    private int currentScore;
    
    void Start()
    {
        
        scoretrigger =  GameObject.FindGameObjectWithTag("Finish");
        
        // currentScore = GameManager.scoreInit;

    }
    void Update()
    {   
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
        
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            Debug.Log("score");
            GameManager.scoreInit+=1;
            
            
            
            
            // Instantiate(ScoreBoard);
            // Destroy(GameObject.FindGameObjectsWithTag("Score")[1]);
            
        }
    }
    


}
