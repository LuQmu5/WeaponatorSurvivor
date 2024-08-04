using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpinner : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 1;

    private void Start()
    {
        StartCoroutine(Spinning());
    }

    private IEnumerator Spinning()
    {
        while (true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * _rotationSpeed);

            yield return null;
        }
    }
}
