﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float time;
    public GameObject lechuga;
    Vector3 position;
    void Start()
    {
        StartCoroutine(spawn());
        Debug.Log("Pre-Brandomloco");
    }
    IEnumerator spawn()
    {
        while (true)
        {
            Debug.Log("Brandomloco");
            float brandom = Random.Range(-2.3f, 2.3f);
            yield return new WaitForSeconds(time);
            position = new Vector3(brandom, 10, 0);
            Instantiate(lechuga, position, Quaternion.identity);
            Debug.Log("Brandomlocoteasdfghjkl");
        }
    }
}