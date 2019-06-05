using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    private float totalTime;
    public int minute;
    public float second;
    public float decreaseTime; // when player get meeting target.
    public Text timerText;
    public GameObject EndText;
    private float oldSecond;

    void Start()
    {
        totalTime = minute * 60 + second;
        oldSecond = 0f;
        EndText.SetActive(false);
    }

    void Update()
    {
        if (totalTime < 0)
        {
            return;
        }

        Debug.Log("countdownTotalTime:" + totalTime);

        totalTime -= Time.deltaTime;

        minute = (int) totalTime / 60;
        second = totalTime - minute * 60;

        if((int) second != (int) oldSecond)
        {
            timerText.text = minute.ToString("00") + ":" + second.ToString("00");
            oldSecond = second;
        }
        if(totalTime < 0)
        {
            timerText.text = "00:00";
            EndText.SetActive(true);
        }
    }

    public void DecreaseTime(int min, float sec)
    {
        Debug.Log(totalTime);
        totalTime = minute * 60 + second - decreaseTime;
        Debug.Log("after:" + totalTime);
    }
}
