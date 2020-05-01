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
    public GameObject gameOverScreen;
    public static Bar instance;
    public GameObject phase;
    public Text phaseText;
    public bool inPhase2;
    public bool inPhase3;
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

        phaseText.text = "1";

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
        
        if(inPhase2 == true)
        {
            phaseText.text = "2";

        }

        if (inPhase2 == true && inPhase3 == true)
        {
            phaseText.text = "3";

        }
    }

    void GameOver()
    {
        if (timerBar.fillAmount == 0)
        {
            Debug.Log("Game Over");
            gameOverScreen.SetActive(true);
            PlayerController.instance.canMove = false;
            PlayerController.instance.canMove = false;
        }
    }

    public void ReduceTime()
    {

        timerBar.fillAmount = timerBar.fillAmount - .05f;
    }
}
