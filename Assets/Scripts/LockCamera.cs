using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCamera : MonoBehaviour
{
    public GameObject player;
    public GameObject maincamera;
    public float timeLeft;
    public bool startCount;

    void Start()
    {
        startCount = false;
    }

    void Update()
    {
        MouseLook playerCam = player.GetComponent<MouseLook>();
        MouseLook mainCam = maincamera.GetComponent<MouseLook>();

        if (startCount)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                timeLeft = -1;
                GameObject.Find("Player").GetComponent<FirstPersonDrifter>().enabled = true;
                playerCam.minimumX = -360;
                playerCam.maximumX = 360;
                mainCam.minimumY = -85;
                mainCam.maximumY = 85;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && timeLeft >= 0)
        {
            //start countdown
            startCount = true;

            MouseLook playerCam = player.GetComponent<MouseLook>();
            MouseLook mainCam = maincamera.GetComponent<MouseLook>();

            GameObject.Find("Player").GetComponent<FirstPersonDrifter>().enabled = false;
            playerCam.minimumX = -30;
            playerCam.maximumX = 30;
            mainCam.minimumY = -10;
            mainCam.maximumY = 10;



        }

    }
}
