using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;

    private PlayerMovement _playerM;

    private readonly int xHash = Animator.StringToHash("X");
    private readonly int yHash = Animator.StringToHash("Y");

    private void Awake()
    {
        _animator = GetComponent<Animator>();

        _playerM = GetComponent<PlayerMovement>();
    }

    public void JumpAnim()
    {
        _animator.SetBool(yHash, true);
    }


}
