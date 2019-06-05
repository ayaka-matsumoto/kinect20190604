using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text creditText;
    public Text rPointText;
    private int credit;
    private int rPoint;

    // private string scoreKey = "score";

    void Start()
    {
        Initialize();
    }
    

    void Update()
    {
        creditText.text = credit.ToString();
        rPointText.text = rPoint.ToString();
    }

    private void Initialize()
    {
        credit = 0;
        rPoint = 0;
    }

    public void AddCreditPoint(int point)
    {
        credit = credit + point;
    }

    public void AddResearchPoint(int point)
    {
        rPoint = rPoint + point;
    }

}
