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
        float totalTime = FindObjectOfType<CountDownTimer>().totalTime;
        if (totalTime > 0)
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
    }
}
