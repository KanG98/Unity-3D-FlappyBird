using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Button : MonoBehaviour
{   
    public GameManager manager;
    
    public void OnButtonPress(){
        
        manager.running = true;
        manager.Restart();
    }

    public void quitButton(){
        manager.running = false;
        Application.Quit();
    }

    
    

    
}
