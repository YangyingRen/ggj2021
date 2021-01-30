using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject AnimationObject;
    void Start()
    {
        AnimationObject.SetActive(false);
    }

    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("player entered");
            AnimationObject.SetActive(true);

        }
    }

}
