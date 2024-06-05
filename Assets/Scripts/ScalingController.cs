using System;
using UnityEngine;

public class ScalingController : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed;
    [SerializeField] private Vector3 _smallestSize;
    [SerializeField] private Vector3 _biggestSize;

    private Transform _transform;
    private float _scalingTime;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        _scalingTime += Time.deltaTime * _scalingSpeed;
        var progress = (Mathf.Sin(_scalingTime) + 1) / 2;
        
        _transform.localScale = Vector3.Lerp(_smallestSize, _biggestSize, progress);
    }
}
