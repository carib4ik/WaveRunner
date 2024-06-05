using UnityEngine;

public class VerticalMovingController : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;
    [SerializeField] private Vector3 _topPosition;
    [SerializeField] private Vector3 _downPosition;

    private Transform _transform;
    private float _movingTime;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        
        _topPosition.x = _transform.position.x;
        _downPosition.x = _transform.position.x;
    }

    private void Update()
    {
        _movingTime += Time.deltaTime;
        var progress = Mathf.PingPong(_movingTime, _movingSpeed) / _movingSpeed;
        
        _transform.localPosition = Vector3.Lerp(_topPosition, _downPosition, progress);
    }
}