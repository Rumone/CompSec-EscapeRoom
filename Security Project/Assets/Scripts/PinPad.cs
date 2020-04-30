using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinPad : MonoBehaviour
{
    string theName;
    public GameObject inputField;
    public GameObject panel;

    public GameObject door;
    public GameObject door2;

    string answer1 = "125417";
    public bool canActivate;
    public Image timerBar;
    public static PinPad instance;
    // Start is called before the first frame update

    private void Start()
    {
        instance = this;

    }
    // Update is called once per frame
    void Update()
    {
        if (canActivate == true && Input.GetKeyUp("space"))
        {
            panel.SetActive(true);
            PlayerController.instance.canMove = false;
        }

        
    }

    public void storeName()
    {
        theName = inputField.GetComponent<Text>().text;
        if (string.Compare(theName, answer1) == 0)
        {
            panel.SetActive(false);
            Debug.Log("Correct");
            door.SetActive(true);
            door2.SetActive(true);
            PlayerController.instance.canMove = true;


        }
        else
        {
            Debug.Log("Wrong");
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

}
