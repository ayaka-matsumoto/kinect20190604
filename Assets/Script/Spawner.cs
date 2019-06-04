using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public float interval;
    public float range = 3.0f;
    private Vector3 wallPosition;

    void Awake()
    {
        wallPosition = GameObject.Find("Wall").transform.position;
    }
    

    IEnumerator Start()
    {
        while (true)
        {
            float positionY = Random.Range(-range, range) + wallPosition.y;
            transform.position = new Vector3(transform.position.x, positionY, transform.position.z);
            Instantiate(Enemy, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }
    }
    
    void Update()
    {
        
    }
}
