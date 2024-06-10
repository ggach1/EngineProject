using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private float _mapSpeed = 15f;

    private void Update()
    {
        transform.Translate(-_mapSpeed * Time.deltaTime, 0, 0);
    }
}
