﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiemonZegt : MonoBehaviour
{
    public Light lt;
    public int start = 1;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {

        lt.color = (Color.red);
        Debug.Log("Red");
        yield return new WaitForSeconds(1);
        lt.color = (Color.green);
        Debug.Log("Green");
        yield return new WaitForSeconds(1);
        lt.color = (Color.blue);
        Debug.Log("blue");
        yield return new WaitForSeconds(1);
        lt.intensity = 0;
        yield return new WaitForSeconds(10);
        lt.intensity = 1;
        StartCoroutine(ExampleCoroutine());
    }
}
