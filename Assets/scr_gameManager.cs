using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_gameManager : MonoBehaviour
{

    public GameObject orangePlayer;
    public Camera startCam;

    // Start is called before the first frame update
    void Start() {
        orangePlayer.SetActive(false);
        startCam.enabled = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            orangePlayer.SetActive(true);

        }
    }
}
