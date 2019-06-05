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

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //EndText.SetActive(false);
                Destroy(EndText.gameObject);
                FindObjectOfType<ShowResult>().showResult();
            }
        }
    }

    public void DecreaseTime(int min, float sec)
    {
        totalTime = minute * 60 + second - decreaseTime;
        ParticleSystem timeParticle = FindObjectOfType<Score>().timeParticle;
        timeParticle.Emit(1);
    }
}
