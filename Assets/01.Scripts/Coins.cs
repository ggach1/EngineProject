using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private ScoreManager _scoreManager;

    private int _currentScore = 0;

    private void Awake()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _currentScore += 1;

            _scoreManager.Setscore(_currentScore);
            
            Destroy(gameObject);

            //Debug.Log("코인 얻음");
        }
    }
}
