using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    //public float waitTime = 30.0f;

    public static Timer instance;

    private void Start()
    {
        instance = this;

        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        timerBar.color = Color.green;

    }

    private void Update()
    {

        
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
            //timerBar.fillAmount -= 1.0f / waitTime * Time.deltaTime;
        }
        else
        {
            Time.timeScale = 0;
        }

        if (timerBar.fillAmount <= 0.6)
        {
            timerBar.color = Color.yellow;
        }

        if (timerBar.fillAmount <= 0.3)
        {
            timerBar.color = Color.red;
        }
        
    }


    public void ReduceTime()
    {
        timerBar.fillAmount = timerBar.fillAmount - .1f;
        Debug.Log(timerBar.fillAmount);
    }
}
//trigger this function after first instructions played?
