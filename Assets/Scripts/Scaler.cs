using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _maximumScale = new Vector3(5, 5, 5);
    [SerializeField] private float _speed = 3;
    private Vector3 _startScale;
    private Vector3 _scaleDirection = Vector3.one;

    private void Start()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        if (transform.localScale.x >= _maximumScale.x)
        {
            _scaleDirection = -Vector3.one;
        }
        else if (transform.localScale.x <= _startScale.x)
        {
            _scaleDirection = Vector3.one;
        }

        transform.localScale += _scaleDirection * _speed * Time.deltaTime;
    }
}
