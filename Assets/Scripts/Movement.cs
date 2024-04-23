using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;
    
    void Start()
    {
        // _rigidbody = GetComponent<Rigidbody>();
    }
}
