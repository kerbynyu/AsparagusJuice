using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followOrange : MonoBehaviour
{

    public Transform target;
    public GameObject thing; //the orange lmao bad naming conventions

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position;
    }
}
