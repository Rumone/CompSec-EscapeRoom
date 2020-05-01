using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject keyPanel;
    public bool canActivate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canActivate == true && Input.GetKeyUp("space"))
        {
            keyPanel.SetActive(true);
            PlayerController.instance.canMove = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            canActivate = true;
            PlayerController.instance.HasKey = true;
        }
    }

    public void CloseWindow()
    {
        keyPanel.SetActive(!keyPanel);
        PlayerController.instance.canMove = true;

    }

}
