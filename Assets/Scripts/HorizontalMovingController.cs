using UnityEngine;

public class HorizontalMovingController : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;
    [SerializeField] private float _movementDelta;
    
    private Vector3 _leftPosition;
    private Vector3 _rightPosition;

    private Transform _transform;
    private float _movingTime;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        
        _leftPosition = new Vector3(transform.position.x - _movementDelta, transform.position.y, transform.position.z);
        _rightPosition = new Vector3(transform.position.x + _movementDelta, transform.position.y, transform.position.z);
    }

    private void Update()
    {
        _movingTime += Time.deltaTime;
        var progress = Mathf.PingPong(_movingTime, _movingSpeed) / _movingSpeed;
        
        _transform.localPosition = Vector3.Lerp(_leftPosition, _rightPosition, progress);
    }
}
