using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableHammer : MonoBehaviour
{
   // [SerializeField] private GameObject _model1;
    [SerializeField] private List<GameObject> _models = new List<GameObject>();

    [SerializeField] private List<MeshRenderer> _meshRenderers = new List<MeshRenderer>();
    // Start is called before the first frame update
    private void Start()
    {
        for (int m = 0; m < _models.Count; m++)
        {
            _models[m].SetActive(false);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (!other.gameObject.CompareTag("Launcher")) return;
        for (int m = 0; m < _models.Count; m++)
        {
            _models[m].SetActive(true);
        }

        Debug.Log(other.gameObject.name);

        for (int i = 0; i < _meshRenderers.Count; i++)
        {
            _meshRenderers[i].enabled = false;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.gameObject.CompareTag("Launcher")) return;
        for (int m = 0; m < _models.Count; m++)
        {
            _models[m].SetActive(false);
        }

        for (int i = 0; i < _meshRenderers.Count; i++)
        {
            _meshRenderers[i].enabled = true;
        }
    }
}
