using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;

    private void Awake()
    {
        _playerMovement = FindObjectOfType<PlayerMovement>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _playerMovement.OnPanel();

            Debug.Log("플레이어 감지");
        }
    }
}
