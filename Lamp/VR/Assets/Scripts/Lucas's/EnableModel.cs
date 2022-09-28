using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableModel : MonoBehaviour
{
    [SerializeField] private GameObject _model;

    [SerializeField] private List<MeshRenderer> _meshRenderers = new List<MeshRenderer>();
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        _model.SetActive(true);
        Debug.Log(other.gameObject.name);

        for (int i = 0; i < _meshRenderers.Count; i++)
        {
            _meshRenderers[i].enabled = false;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        _model.SetActive(false);
        
        for (int i = 0; i < _meshRenderers.Count; i++)
        {
            _meshRenderers[i].enabled = true;
        }
    }
}
