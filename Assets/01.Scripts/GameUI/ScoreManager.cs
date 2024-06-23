using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int _currentScore = 0; //���� ����
    public TextMeshProUGUI _currentScoreUI; //�������� ǥ�� UI

    public static ScoreManager Instance = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void Setscore(int value)
    {
        _currentScore += value;
        _currentScoreUI.text = $"Score : {_currentScore}";
    }

    public int Getscore()
    {
        return _currentScore;
    }
}
