using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private float _speed = 4f;

    [SerializeField] private float _jump = 10f;

    [SerializeField] private float _jump2 = 55f;

    int _jumpCount = 0;

    private Rigidbody2D _rigid;

    private PlayerAnimation _animation;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();

        _animation = FindObjectOfType<PlayerAnimation>();
    }

    private void Update()
    {
        TryJump();

        //_animation.RunAnim();
    }

    public void TryJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpTime();
        }
        else
        {
            _animation.RunAnim();
        }

        
    }

    public void Jump()
    {
        _rigid.AddForce(Vector2.up.normalized * _jump, ForceMode2D.Impulse); // 순간적으로 강한 힘을 줌 
    }

    public void JumpTime()
    {
        if (_jumpCount < 2 && _jumpCount >= 0)
        {
            if (_jumpCount == 0)
            {
                Jump();
                _rigid.velocity = new Vector3(0f, _jump, 0f);
                _jumpCount += 1;
                _animation.JumpAnim();
                
            }
            else if (_jumpCount == 1)
            {
                Jump();
                _rigid.velocity = new Vector3(0f, _jump2, 0f);
                _jumpCount += 1;
                _animation.DoubleJumpAnim();
                //DontJump();
            }

        }
    }

    private void DontJump()
    {
        _rigid.velocity = Vector3.down * 1.75f;

        Debug.Log("점프하지마");

        _animation.FallAnim();
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
