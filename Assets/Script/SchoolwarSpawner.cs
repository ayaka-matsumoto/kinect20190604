﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolwarSpawner : MonoBehaviour
{
    public GameObject Enemy;
    public float interval;
    public float range = 3.0f;

    IEnumerator Start()
    {
        while (true)
        {
            transform.position = new Vector3(Random.Range(-range, range), transform.position.y, transform.position.z);
            Instantiate(Enemy, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }
    }

    void Update()
    {

    }
}
