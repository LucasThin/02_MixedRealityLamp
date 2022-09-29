using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public AudioClip audioclip;
    public AudioSource source;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacles"))
        {
            source = other.gameObject.GetComponent<AudioSource>();
            audioclip = source.clip;
            source.PlayOneShot(audioclip);
            Debug.Log("Saber hit");
            Destroy(other.gameObject);
        }
    }
}
