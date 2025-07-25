using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    private float _startXPosition;
    [SerializeField] private float _endXPosition = -10f;
    [SerializeField] private int _speed = 3;
    private Vector3 _movementDirection = Vector3.left;



    private void Start()
    {
        this._startXPosition = transform.position.x;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (transform.position.x <= this._endXPosition)
        {
            this._movementDirection = Vector3.right;
        }
        else if (transform.position.x >= this._startXPosition)
        {
            this._movementDirection = Vector3.left;
        }

        transform.Translate(_movementDirection * _speed * Time.deltaTime);
    }
}
