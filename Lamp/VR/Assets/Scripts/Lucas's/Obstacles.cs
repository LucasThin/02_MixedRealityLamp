using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacles"))
        {
            Debug.Log("Saber hit");
            Destroy(other.gameObject);
        }
    }
}
