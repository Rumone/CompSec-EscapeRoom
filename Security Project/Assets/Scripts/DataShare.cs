using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataShare : MonoBehaviour
{
    public GameObject test;
    public GameObject codePanel;
    public GameObject keyCodeDoor;

    public GameObject rightPanel;
    public GameObject wrongPanel;
    public int num;
    public bool canActivate;
    public static DataShare instance;

    public bool inDevice;

    public Image timerBar;

    public GameObject BathroomExit;
    public GameObject BathroomEntrance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        print(num);
        if (canActivate == true && Input.GetKeyUp("space") && inDevice != true)
        {
            codePanel.SetActive(true);
            PlayerController.instance.canMove = false;
        }
        if (num == 2)
        {
            num = 0;

            inDevice = true;
            rightPanel.gameObject.SetActive(true);
            PlayerController.instance.canMove = false;
            keyCodeDoor.SetActive(true);
            codePanel.SetActive(false);
            BathroomEntrance.SetActive(false);
            BathroomExit.gameObject.SetActive(false);
        }
        else if (num == 1 || num ==3)
        {
            timerBar.fillAmount = timerBar.fillAmount - .009f;
            codePanel.SetActive(false);
            wrongPanel.gameObject.SetActive(true);
            
                
            num = 0;
        }

        if(canActivate == true && inDevice && Input.GetKeyUp("space"))
        {
            rightPanel.gameObject.SetActive(true);
            PlayerController.instance.canMove = false;
        }


    }

    public void CloseWidnow()
    {
        codePanel.gameObject.SetActive(false);
        PlayerController.instance.canMove = true;
    }

    

    public void CloseWinWindow()
    {
        codePanel.gameObject.SetActive(false);
        rightPanel.gameObject.SetActive(false);
        PlayerController.instance.canMove = true;
    }

    public void CloseLoseWindow()
    {
        codePanel.gameObject.SetActive(false);
        wrongPanel.gameObject.SetActive(false);
        PlayerController.instance.canMove = true;
    }
    public void SetOne()
    {
        num = 1;
    }
    public void SetTwo()
    {
        num = 2;
    }
    public void SetThree()
    {
        num = 3;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            canActivate = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            canActivate = false;
    }
}
