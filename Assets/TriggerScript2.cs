using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2: MonoBehaviour
{
    public Camera camera2;
    public Camera camera3;
    

    public GameObject cup;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ENTER" + other.name + "");
        if (other.name.Equals("Orange"))
        {

            camera2.enabled = false;
            camera3.enabled = true;

            
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("EXIT");
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
