﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Router : MonoBehaviour
{
    public bool canActivate;
    public GameObject rPanel;
    public GameObject ExittoServerScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canActivate == true && Input.GetKeyUp("space"))
        {
            rPanel.SetActive(true);
            PlayerController.instance.canMove = false;
        }
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

    public void CloseCPanel()
    {
        rPanel.SetActive(false);
        PlayerController.instance.canMove = true;
    }

    public void CorrectButton()
    {
        rPanel.SetActive(false);
        Bar.instance.inPhase3 = true;
        ExittoServerScene.SetActive(true);
    }
}
