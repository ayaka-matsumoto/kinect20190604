using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolwarPlayer : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 360f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(direction.sqrMagnitude > 0.01f)
        {
            Vector3 forward = Vector3.Slerp(
                transform.forward,
                direction,
                rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, direction));
            transform.LookAt(transform.position + forward);
            transform.position += direction * 0.05f;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Credit(Clone)")
        { 
            FindObjectOfType<Score>().AddCreditPoint(10);
            Destroy(col.gameObject);
        }
        if(col.gameObject.name == "Meeting(Clone)")
        {
            FindObjectOfType<Score>().AddResearchPoint(10);

            int minute = FindObjectOfType<CountDownTimer>().minute;
            float second = FindObjectOfType<CountDownTimer>().second;

            FindObjectOfType<CountDownTimer>().DecreaseTime(minute, second);

            Destroy(col.gameObject);
        }
    }
}
