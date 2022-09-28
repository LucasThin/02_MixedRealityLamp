using System;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    [SerializeField] private Material _purpleSky;
    private float _Timer;
    [SerializeField] private float _duration = 5f;
    [SerializeField] private bool _shotFired = false;
    // Start is called before the first frame update
    private void Start()
    {
        _Timer = _duration;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            Debug.Log("collision");
            _shotFired = true;
            Destroy(other.gameObject, 5f);
        }
    }

    private void Update()
    {
        if (_shotFired)
        {
            if (_Timer > 0)
            {
                _Timer -= Time.deltaTime;
                Debug.Log(_Timer);
            }
            else if (_Timer < 0.9f)
            {
                Debug.Log("Change skybox");
                RenderSettings.skybox = _purpleSky;
                DynamicGI.UpdateEnvironment();
                _shotFired = false;
            }   
        }
    }
}
