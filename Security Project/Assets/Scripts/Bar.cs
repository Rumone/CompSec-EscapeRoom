using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    public float waitTime = 30.0f;

    public static Bar instance;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        timerBar.color = Color.green;

    }

    private void Update()
    {

        GameOver();
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            //timerBar.fillAmount = timeLeft / maxTime;
            timerBar.fillAmount -= 1.0f / waitTime * Time.deltaTime;
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
        //Debug.Log(timerBar.fillAmount);
    }

    void GameOver()
    {
        if (timerBar.fillAmount == 0)
        {
            Debug.Log("Times up");
        }
    }

    public void ReduceTime()
    {

        timerBar.fillAmount = timerBar.fillAmount - .05f;
    }
}
