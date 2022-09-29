using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightsabre : MonoBehaviour
{
    private GameObject laser;
    private Vector3 fullSize;
    
    // Start is called before the first frame update
    void Start()
    {
        laser = transform.Find("SingleLine-LightSaber").gameObject;
        fullSize = laser.transform.localScale;
        laser.transform.localScale = new Vector3(fullSize.x, 0, fullSize.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (laser.transform.localScale.y < fullSize.y)
        {
            laser.transform.localScale += new Vector3(x: 0, y: 0.00001f, 0);
        }
    }
}
