using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMovement2 : MonoBehaviour
{

    public Transform target;
    public GameObject thing; //the orange lmao bad naming conventions


    void Start()
    {

       
    }

    int DistanceAway = 10;

    void Update()
    {

        transform.position = target.transform.position;

       
    }
}
