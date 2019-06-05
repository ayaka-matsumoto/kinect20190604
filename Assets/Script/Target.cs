using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Destroy(gameObject, 10f);
    }
    

    void Update()
    {
        int minute = FindObjectOfType<CountDownTimer>().minute;
        float second = FindObjectOfType<CountDownTimer>().second;
        float totalTime = minute * 60 + second;
        if (totalTime > 0)
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
    }
}
