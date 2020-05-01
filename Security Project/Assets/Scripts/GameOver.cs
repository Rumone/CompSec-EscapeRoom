using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject FadeOut;
    public GameObject lockScreen;
    public bool canActivate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerController.instance.HasKey == true && canActivate == true && Input.GetKeyUp("space"))
        {
            FadeOut.SetActive(true);
        }

        if(PlayerController.instance.HasKey == false && canActivate == true && Input.GetKeyUp("space"))
        {
            lockScreen.SetActive(true);
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
        {
            canActivate = false;
            lockScreen.SetActive(false);
        }
    }
}
