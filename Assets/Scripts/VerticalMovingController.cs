using UnityEngine;

public class VerticalMovingController : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;
    [SerializeField] private float _movementDelta;
    
    private Vector3 _topPosition;
    private Vector3 _downPosition;

    private Transform _transform;
    private float _movingTime;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        
        _topPosition = new Vector3(transform.position.x , transform.position.y + _movementDelta, transform.position.z);
        _downPosition = new Vector3(transform.position.x, transform.position.y - _movementDelta, transform.position.z);
    }

    private void Update()
    {
        _movingTime += Time.deltaTime;
        var progress = Mathf.PingPong(_movingTime, _movingSpeed) / _movingSpeed;
        
        _transform.localPosition = Vector3.Lerp(_topPosition, _downPosition, progress);
    }
}