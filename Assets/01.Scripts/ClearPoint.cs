using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearPoint : MonoBehaviour
{
    [SerializeField] private string _scenename;

    public void BackSelect()
    {
        SceneManager.LoadScene(_scenename);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BackSelect();
    }
}
