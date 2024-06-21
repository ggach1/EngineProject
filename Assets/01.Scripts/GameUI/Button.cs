using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Button : MonoBehaviour
{
    [SerializeField] private string _sceneName;

    private float _delay = 1.5f;

    [SerializeField] private GameObject _panelOne;


    private void Start()
    {
        _panelOne.SetActive(false);
    }

    public void Back()
    {
        StartCoroutine(EnterDelay());

        SceneManager.LoadScene(_sceneName);
    }

    public void StageOne()
    {
        // StartCoroutine(EnterDelay());
        _panelOne.SetActive(true);
    }

    public void Yes()
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void No()
    {
        _panelOne?.SetActive(false);
    }

    private IEnumerator EnterDelay()
    {
        yield return new WaitForSeconds(_delay);
    }
}
