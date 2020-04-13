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
    bool canActivate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (canActivate == true && Input.GetKeyUp("space"))
        {
            codePanel.SetActive(true);
            PlayerController.instance.canMove = false;
        }
        if (num == 2)
        {
            Debug.Log("You win");
            rightPanel.gameObject.SetActive(true);
            PlayerController.instance.canMove = false;
            keyCodeDoor.SetActive(true);
            codePanel.SetActive(false);
            num = 0;
        }
        else if (num == 1 || num ==3)
        {
            
            codePanel.SetActive(false);
            wrongPanel.gameObject.SetActive(true);
            num = 0;
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
        rightPanel.gameObject.SetActive(!rightPanel.activeSelf);
        PlayerController.instance.canMove = true;
    }

    public void CloseLoseWindow()
    {
        codePanel.gameObject.SetActive(false);
        wrongPanel.gameObject.SetActive(!wrongPanel.activeSelf);
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
