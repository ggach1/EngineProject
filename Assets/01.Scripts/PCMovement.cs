using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PCMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 4f;

    

    private Rigidbody2D _rigid;

    private PCInput _input;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();

        _input = GetComponent<PCInput>();
    }

    private void FixedUpdate()
    {
        _rigid.velocity = Vector2.right * _speed;
    }
}
