using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpinner : MonoBehaviour
{
    private const float FullRadius = 360;

    [SerializeField] private float _turnsPerSecond = 1;

    private void Start()
    {
        StartCoroutine(Spinning());
    }

    private IEnumerator Spinning()
    {
        while (true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * _turnsPerSecond * FullRadius);

            yield return null;
        }
    }
}
