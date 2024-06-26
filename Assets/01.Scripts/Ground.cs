using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private float _mapSpeed = 13f;

    private void Update()
    {
        transform.Translate(-_mapSpeed * Time.deltaTime * 1.75f, 0, 0);
    }
}
