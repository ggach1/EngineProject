using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;

    private readonly int xHash = Animator.StringToHash("X");
    private readonly int yHash = Animator.StringToHash("Y");

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
}
