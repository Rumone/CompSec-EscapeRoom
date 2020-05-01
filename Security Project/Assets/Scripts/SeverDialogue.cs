using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeverDialogue : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Laptop;
    public GameObject Panel2;
    public GameObject Router;
    public GameObject Text;
    public GameObject fadeOut;

    public bool canActivate;
    public bool FoundLaptop = false;

    private void Update()
    {
        if(canActivate== true && Input.GetKeyUp("space"))
        {
            Panel.SetActive(true);
            PlayerController.instance.canMove = false;
            

        }

        if(canActivate == true && Input.GetKeyUp("space") && FoundLaptop == true)
        {
            Panel2.SetActive(true);
            PlayerController.instance.canMove = false;
        }
    }

    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            canActivate = true;
            
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
            canActivate = false;
    }

    public void GetInput(string answer)
    {
        
        if(answer == "ilikestealing")
        {
            Panel.SetActive(false);
            Text.GetComponent<Text>().text = "Correct";
            Panel2.SetActive(true);
            
            Router.SetActive(true);
            Debug.Log(Router);
        }
        else{
            Debug.Log("Wrong!");
        }
    }

    public void Close()
    {
        Panel2.SetActive(!Panel2);
        PlayerController.instance.canMove = true;
    }

    public void CorrectButton()
    {
        Panel.SetActive(false);
        Panel2.SetActive(true);
        Bar.instance.inPhase3 = true;
    }

    public void GameOver()
    {
        fadeOut.SetActive(true);
        PlayerController.instance.canMove = false;
    }

}
