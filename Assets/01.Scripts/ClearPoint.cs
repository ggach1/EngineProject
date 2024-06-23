using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearPoint : MonoBehaviour
{
    [SerializeField] private GameObject _endPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _endPanel.SetActive(true);
        }
    }
}
