using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkyboxLauncher : MonoBehaviour
{
    [SerializeField] private GameObject _model;

    [SerializeField] private List<MeshRenderer> _meshRenderers = new List<MeshRenderer>();

    [SerializeField] private float _Time;
    [SerializeField] private float _duration = 10f;
    [SerializeField] private bool _modelShowing = false;
    [SerializeField] private TMP_Text _Timertext;
    // Start is called before the first frame update

    private void Start()
    {
        _Time = _duration;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        _model.SetActive(true);
        //Debug.Log(other.gameObject.name);

        for (int i = 0; i < _meshRenderers.Count; i++)
        {
            _meshRenderers[i].enabled = false;
        }

        _modelShowing = true;

    }


    private void OnTriggerExit(Collider other)
    {
        _model.SetActive(false);
        
        for (int i = 0; i < _meshRenderers.Count; i++)
        {
            _meshRenderers[i].enabled = true;
        }

        _modelShowing = false;
    }

    private void Update()
    {
        if (_modelShowing)
        {
            Debug.Log(_Time);
            if (_Time > 0.9f)
            {
                _Time = _Time - Time.deltaTime;
                _Timertext.text = _Time.ToString("F1");
            }
            else
            {
                _Timertext.text = "0";
            }
            
        }
        else
        {
            ResetTimer();
        }
    }
    
    private void ResetTimer()
    {
        _Time = _duration;
    }
}