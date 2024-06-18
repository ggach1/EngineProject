using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SelectStageUI : MonoBehaviour
{
    [SerializeField] private GameObject _panel1;

    private Button _button;

    private void Awake()
    {
        _button = FindObjectOfType<Button>();
    }

    private void Start()
    {
        _panel1.SetActive(false);
    }
}
