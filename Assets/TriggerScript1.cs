using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript1 : MonoBehaviour
{

    public Camera prevCam;
    public Camera newCam;
   

    void Start(){
        
    }

    private void OnTriggerEnter2D(Collider2D other){
      
        if (other.name.Equals("Orange")||other.name.Equals("Orange2")) {

            prevCam.enabled = false;
            newCam.enabled = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision){
        
    }

    private void OnTriggerExit2D(Collider2D collision){
       
    }


    void Update() {
        
    }

}
