using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;

    private PlayerMovement _playerM;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void RunAnim()
    {
        _animator.SetBool("isJump", false);
        _animator.SetBool("isDoubleJump", false);
        _animator.SetBool("isFall", false);
        _animator.SetBool("isRun", true);
    }

    public void JumpAnim()
    {
        _animator.SetBool("isRun", false);
        _animator.SetBool("isJump", true);
    }

    public void DoubleJumpAnim()
    {
        _animator.SetBool("isJump", false);
        _animator.SetBool("isDoubleJump", true);
    }

    public void FallAnim()
    {
        _animator.SetBool("isJump", false);
        _animator.SetBool("isDoubleJump", false);
        _animator.SetBool("isFall", true);
    }


}
