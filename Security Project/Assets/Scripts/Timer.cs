using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image timerBar;
    public float maxTime = 5f;
    float timeLeft;

    public static Timer instance;

    private void Start()
    {
        instance = this;

        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    private void Update()
    {
        GameOver();
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    void GameOver()
    {
        if (timerBar.fillAmount == 0)
        {
            //Debug.Log("Times up");
        }
    }
}
//trigger this function after first instructions played?
