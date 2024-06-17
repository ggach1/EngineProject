using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
}
