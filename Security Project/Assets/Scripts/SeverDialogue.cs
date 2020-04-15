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
    public void OnTriggerEnter2D(Collider2D other)
    {
       
        if(other.tag == "Player")
        {
            Panel.SetActive(true);
        }

        if(Laptop != null)
        {
            Laptop.SetActive(true);
        }

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
        Panel2.SetActive(false);

    }

    public void CorrectButton()
    {
        Panel.SetActive(false);
        Panel2.SetActive(true);
    }


}
