using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laptop : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject panel;

    public GameObject panel2;
    public GameObject router;
    string answer1 = "asd";
    //ilikestealing
    public bool canActivate;
    public bool inLaptp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canActivate == true && Input.GetKeyUp("space"))
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
            Debug.Log("You have access");
            inLaptp = true;
            panel.SetActive(false);
            panel2.SetActive(true);
            router.SetActive(true);
        }
        
    }

    public void closePanel()
    {
        panel.SetActive(true);
        PlayerController.instance.canMove = true;
    }

    public void CloseEmail()
    {
        panel2.SetActive(false);
        PlayerController.instance.canMove = true;
    }
    public void PhishingLink()
    {
        Bar.instance.gameOverScreen.SetActive(true);
        panel2.SetActive(false);
        
        PlayerController.instance.canMove = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
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
