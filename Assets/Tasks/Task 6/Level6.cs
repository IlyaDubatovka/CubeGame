using System;
using UnityEngine;

public class Level6 : MonoBehaviour
{
    [SerializeField] 
    private GameObject _obstacle;
    
    private float _speed = 5;
    private Rigidbody oRigidbody;

    private void Start()
    {
        _obstacle = Instantiate(_obstacle, Vector3.zero, Quaternion.identity);
        oRigidbody = _obstacle.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var step = Time.deltaTime * _speed;
        var transformPosition = transform.position;
        transformPosition.x += step;
        

        transform.position = transformPosition; 
    }

    private void FixedUpdate()
    {
        oRigidbody.AddForce(0,10000,0);
    }
}