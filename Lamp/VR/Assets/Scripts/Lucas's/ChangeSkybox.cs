using System;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    [SerializeField] private Material _purpleSky;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            Debug.Log("collision");
            RenderSettings.skybox = _purpleSky;
            DynamicGI.UpdateEnvironment();
        }
    }
}
