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

    public void Enter()
    {
        StartCoroutine(EnterDelay());

        SceneManager.LoadScene(_sceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }

    private IEnumerator EnterDelay()
    {
        yield return new WaitForSeconds(_delay);
    }

    public void Back()
    {
        StartCoroutine(EnterDelay());

        SceneManager.LoadScene(_sceneName);
    }

    public void StageOne()
    {
        StartCoroutine(EnterDelay());

         SceneManager.LoadScene(_sceneName);
    }
}
