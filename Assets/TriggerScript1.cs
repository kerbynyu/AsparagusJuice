using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript1 : MonoBehaviour
{

    public Camera camera1;
    public Camera camera2;

    public GameObject cup;

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("ENTER" + other.name + "");
        if (other.name.Equals("Orange")){

            camera1.enabled = false;
            camera2.enabled = true;

            cup.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

            
           
        }

    }

    private void OnTriggerStay2D(Collider2D collision) {
        
    }

    private void OnTriggerExit2D(Collider2D collision){
        Debug.Log("EXIT");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cup.transform.position.y <= -45)
        {
            cup.SetActive(false);
        }
    }
}
