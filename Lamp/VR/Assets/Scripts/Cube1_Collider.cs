using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public GameObject ObjectToEnable;

    void Start()
    {
        Debug.Log("OUT");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("IN");

    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("OUT");

    }


}
