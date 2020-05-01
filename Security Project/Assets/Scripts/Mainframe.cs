using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainframe : MonoBehaviour
{
    public GameObject filetransferPanel;
    public GameObject internalDialog;
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
            filetransferPanel.SetActive(true);
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

    public void CloseWindow()
    {
        filetransferPanel.SetActive(false);
        internalDialog.SetActive(true);
    }

    public void CloseDialog()
    {
        internalDialog.SetActive(false);
        PlayerController.instance.canMove = true;
    }
}
