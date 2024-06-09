using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 4f;

    [SerializeField] private float _jump = 5f;

    

    private Rigidbody2D _rigid;

    private PlayerInput _input;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();

        _input = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        TryJump();
    }

    private void FixedUpdate()
    {
        _rigid.velocity = Vector2.right.normalized * _speed;
    }

    public void TryJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
           Jump();
    }

    public void Jump()
    {
        _rigid.AddForce(Vector2.up.normalized * _jump, ForceMode2D.Impulse); // 순간적으로 강한 힘을 줌
    }
}
