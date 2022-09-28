using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkyboxLauncher : MonoBehaviour
{
    [SerializeField] private GameObject _model;

    [SerializeField] private List<MeshRenderer> _meshRenderers = new List<MeshRenderer>();
    [SerializeField] private GameObject _bulletObject;
    [SerializeField] private float _bulletSpeed = 5;
    [SerializeField] private Transform _firePosition;
    [SerializeField] private float _Time;
    [SerializeField] private float _duration = 10f;
    [SerializeField] private bool _modelShowing = false;
    [SerializeField] private TMP_Text _Timertext;

    private int _shootBullet = 1;
    // Start is called before the first frame update

    private void Start()
    {
        _Time = _duration;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //FireBullet();
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
                if (_shootBullet > 0)
                {
                    FireBullet();
                }
            }
            
        }
        else
        {
            ResetTimer();
            
        }
        
    }

    private void FireBullet()
    {
        _shootBullet = 0;
        var bullet = Instantiate(_bulletObject, _firePosition.position, Quaternion.identity).GetComponent<Rigidbody>();
        bullet.AddForce(_firePosition.forward*_bulletSpeed, ForceMode.Impulse);
    }

    private void ResetTimer()
    {
        _shootBullet = 1;
        _Time = _duration;
    }
}