using System;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        _transform.Rotate(0,0,_rotationSpeed * Time.deltaTime);
    }
}
