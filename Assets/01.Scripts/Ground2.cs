using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground2 : MonoBehaviour
{
    [SerializeField] private float _mapSpeed = 13f;

    private void Update()
    {
        transform.Translate(-_mapSpeed * Time.deltaTime * 1.5f, 0, 0);
    }
}
