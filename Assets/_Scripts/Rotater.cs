using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _speedRotate = 10;
    [SerializeField] private Vector3 _direction = Vector3.up;


    void Start()
    {
    
    }

    void Update()
    {
        transform.Rotate(_direction, _speedRotate * Time.deltaTime);
    }
}
