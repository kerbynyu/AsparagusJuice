using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript4 : MonoBehaviour
{
    public Camera camera3;
    public Camera cameraIce;
    public Transform target;
    


    public GameObject cup;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ENTER" + other.name + "");
        if (other.name.Equals("spr_ice"))
        {

            camera3.enabled = false;
            cameraIce.enabled = true;


            target.transform.position = new Vector3(-54, -153, 0);

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
