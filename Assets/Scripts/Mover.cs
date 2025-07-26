using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{    
    [SerializeField] private float _endXPosition = -10f;
    [SerializeField] private int _speed = 3;
    private float _startXPosition;
    private Vector3 _movementDirection = Vector3.left;



    private void Start()
    {
        _startXPosition = transform.position.x;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (transform.position.x <= _endXPosition)
        {
            _movementDirection = Vector3.right;
        }
        else if (transform.position.x >= _startXPosition)
        {
            _movementDirection = Vector3.left;
        }

        transform.Translate(_movementDirection * _speed * Time.deltaTime);
    }
}
