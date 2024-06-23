using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Rendering;
//using UnityEditor.SearchService;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private float _speed = 4f;

    [SerializeField] private float _jump = 10f;

    [SerializeField] private float _jump2 = 55f;

    [SerializeField] private GameObject _endpanel;

    int _jumpCount = 0;

    private float _delaytime = 1.5f;

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
        /*else
        {
            _animation.RunAnim();
        }*/

        
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
                StartCoroutine(Delaytime());
                //_animation.FallAnim();
            }
            else if (_jumpCount == 1)
            {
                Jump();
                _rigid.velocity = new Vector3(0f, _jump2, 0f);
                _jumpCount += 1;
                //DontJump();
                StartCoroutine(Delaytime());
                _animation.FallAnim();
            }

        }
    }

    public void Jump()
    {
        _rigid.AddForce(Vector2.up.normalized * _jump, ForceMode2D.Impulse); // 순간적으로 강한 힘을 줌 
    }

    private void DontJump()
    {
        _rigid.velocity = Vector3.down * 1.75f;

        //Debug.Log("점프하지마");

        _animation.FallAnim();
    }

    public void OnPanel()
    {
        _endpanel.SetActive(true);
    }

    public IEnumerator Delaytime()
    {
        yield return new WaitForSeconds(_delaytime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _jumpCount = 0;

            _animation.RunAnim();
        }

        //if (collision.gameObject.CompareTag("Enemy"))
        //{
        //    OnPanel();

        //    Debug.Log("에너미 감지");
        //}

        //if (collision.gameObject.CompareTag("DeadZone"))
        //{
        //    OnPanel();
        //}

        /*if (collision.gameObject.CompareTag("DontJump"))
        {
            _jumpCount = 0;

            DontJump();
        }*/
    }


}
