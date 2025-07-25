using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField]private int _speed = 100;
    [SerializeField] private Vector3 _rotationDirection = Vector3.down;
    
    private void Update()
    {
        transform.Rotate(_rotationDirection * _speed * Time.deltaTime);        
    }
}
