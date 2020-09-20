using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMovement : MonoBehaviour
{

    public Transform target;
    public GameObject thing;

    // Start is called before the first frame update
    void Start(){

        thing.SetActive(false);
    }

    int DistanceAway = 10;

    // Update is called once per frame
    void Update(){

        transform.position = target.transform.position;

        if (Input.GetKeyDown("space")){
            thing.SetActive(true);

        }
    }
}
