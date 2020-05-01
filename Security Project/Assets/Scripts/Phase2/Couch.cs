using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Couch : MonoBehaviour
{
    public bool canActivate;
    public GameObject cPanel;
    public GameObject Laptop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canActivate == true && Input.GetKeyUp("space"))
        {
            Laptop.SetActive(true);
            cPanel.SetActive(true);
            PlayerController.instance.canMove = false;
        }
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

    public void CloseCPanel()
    {
        cPanel.SetActive(false);
        PlayerController.instance.canMove = true;

    }
}
