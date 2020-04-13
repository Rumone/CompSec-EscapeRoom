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
     
    public IEnumerator OnTriggerEnter2D(Collider2D other)
    {
       
        if(other.tag == "Player")
        {
            Panel.SetActive(true);
            Laptop.SetActive(true);
        }

       yield return new WaitForSeconds(5);
        Panel.SetActive(false);
    }

}
