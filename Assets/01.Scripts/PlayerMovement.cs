using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private float _speed = 4f;

    [SerializeField] private float _jump = 10f;

    [SerializeField] private float _jump2 = 35f;

    int _jumpCount = 0;


    

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
        //_rigid.velocity = Vector2.right.normalized * _speed;
    }

    public void TryJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpTime();
        }

        
    }

    public void Jump()
    {
        _rigid.AddForce(Vector2.up.normalized * _jump, ForceMode2D.Impulse); // ¼ø°£ÀûÀ¸·Î °­ÇÑ ÈûÀ» ÁÜ
        
    }

    public void JumpTime()
    {
        if (_jumpCount >= 2)
        {
            DontJump();
        }
        else if (_jumpCount < 2 && _jumpCount >= 0)
        {
            if (_jumpCount == 0)
            {
                Jump();
                _rigid.velocity = new Vector3(0f, _jump, 0f);
                _jumpCount += 1;
            }
            else if (_jumpCount == 1)
            {
                Jump();
                _rigid.velocity = new Vector3(0f, _jump2, 0f);
                _jumpCount += 1;
            }

        }
    }

    private void DontJump()
    {
        _rigid.velocity = Vector3.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _jumpCount = 0;
        }

        /*if (collision.gameObject.CompareTag("DontJump"))
        {
            _jumpCount = 0;

            DontJump();
        }*/
    }
}
