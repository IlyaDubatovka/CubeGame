using UnityEngine;

public class Level2 : MonoBehaviour
{
    private float _speed = 10;
    
    private void Awake()
    {
        var step = Time.deltaTime * _speed;
        var transformPosition = transform.position;
        transformPosition.x += step;

        transform.position = transformPosition;
    }
}