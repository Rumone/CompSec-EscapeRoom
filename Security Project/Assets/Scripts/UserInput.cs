using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UserInput : MonoBehaviour
{
    string theName;
    public GameObject inputField;
    public GameObject panel;

    public GameObject panel2;
    public GameObject dataShareDevice;
    string answer1 = "@PP!3#1";
    //Tg1 @vk!
    public bool canActivate;
    public static UserInput instance;
    public bool inLaptp;
    public GameObject bathoomDoor;

    public Image timerBar;
    //bathroom exit

    // Start is called before the first frame update

    private void Start()
    {
        instance = this;

    }
    // Update is called once per frame
    void Update()
    {
        if (canActivate == true && Input.GetKeyUp("space") && inLaptp != true)
        {
            panel.SetActive(true);
            PlayerController.instance.canMove = false;
        }

        if (canActivate == true && Input.GetKeyDown("space") && inLaptp == true) 
        {
            panel2.SetActive(true);
            panel.SetActive(false);
            dataShareDevice.SetActive(true);
            
        }
    }

    public void storeName()
    {
        theName = inputField.GetComponent<Text>().text;
        if (string.Compare(theName, answer1) == 0)
        {
            Debug.Log("You have access");
            inLaptp = true;
            panel.SetActive(false);
            panel2.SetActive(true);
            bathoomDoor.SetActive(false);
        }
        else
        {
            timerBar.fillAmount = timerBar.fillAmount - .009f;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            canActivate = true;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
            canActivate = false;
    }

    public void CloseMenu()
    {
        panel.SetActive(!panel.activeSelf);
        PlayerController.instance.canMove = true;

    }

    public void CloseLaptopWinow()
    {
        panel2.SetActive(!panel2.activeSelf);
        PlayerController.instance.canMove = true;
        dataShareDevice.SetActive(true);
    }

    
}
