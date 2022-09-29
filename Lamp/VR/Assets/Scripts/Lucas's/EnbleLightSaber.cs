using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnbleLightSaber : MonoBehaviour
{
    [SerializeField] private GameObject _model;
    
    [SerializeField] private GameObject _hammerTop;
    [SerializeField] private GameObject _hammerBottom;

    [SerializeField] private List<MeshRenderer> _meshRenderers = new List<MeshRenderer>();
    // Start is called before the first frame update
    void Start()
    {
        _model.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.CompareTag("LightSaber"))
        {
            Debug.Log(other.gameObject.name);
            _model.SetActive(true);
           // 

            for (int i = 0; i < _meshRenderers.Count; i++)
            {
                _meshRenderers[i].enabled = false;
            }
        } 
        
        


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("LightSaber"))
        {
            _model.SetActive(false);
            // Debug.Log(other.gameObject.name);

            for (int i = 0; i < _meshRenderers.Count; i++)
            {
                _meshRenderers[i].enabled = true;
            }
        }
        
    }
}
