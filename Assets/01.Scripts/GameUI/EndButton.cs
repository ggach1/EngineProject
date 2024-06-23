using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndButton : MonoBehaviour
{
    [SerializeField] private string _scenename;

    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _elsePanel;

    private void Start()
    {
        _panel.SetActive(false);
        _elsePanel.SetActive(false);
    }

    public void Lobby()
    {
        SceneManager.LoadScene(_scenename);
    }

    public void Restart()
    {
        _panel.SetActive(false);
    }

    public void Dead()
    {
        _elsePanel.SetActive(true);
    }
}
