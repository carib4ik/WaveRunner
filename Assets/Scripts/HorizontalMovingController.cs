using System;
using UnityEngine;

public class HorizontalMovingController : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;
    [SerializeField] private Vector3 _leftPosition;
    [SerializeField] private Vector3 _rightPosition;

    private Transform _transform;
    private float _movingTime;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        _movingTime += Time.deltaTime;
        var progress = Mathf.PingPong(_movingTime, _movingSpeed) / _movingSpeed;
        
        _transform.localPosition = Vector3.Lerp(_leftPosition, _rightPosition, progress);
    }
}
