using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCubeLogic : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 3;
    [SerializeField] private float _rotationSpeed = 3;
    [SerializeField] private float _scalingSpeed = 3;

    private Vector3 _startScaling;
    private Vector3 _maxScaling = new Vector3(3, 3, 3);
    private Vector3 _rotationDirection = Vector3.down;
    private Vector3 _scalingDirection = Vector3.one;

    private void Start()
    {
        this._startScaling = transform.localScale;        
    }

    private void Update()
    {
        Move();
        Rotate();
        Scale();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * this._movementSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(_rotationDirection * _rotationSpeed * Time.deltaTime);
    }

    private void Scale()
    {
        if (transform.localScale.x >= _maxScaling.x)
        {
            _scalingDirection = -Vector3.one;
        }
        else if (transform.localScale.x <= _startScaling.x)
        {
            _scalingDirection = Vector3.one;
        }

        transform.localScale += _scalingDirection * this._scalingSpeed * Time.deltaTime;
    }
}
