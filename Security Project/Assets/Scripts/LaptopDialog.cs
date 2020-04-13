using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopDialog : MonoBehaviour
{
    public string[] lines;

    public bool canActivate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canActivate && Input.GetKeyDown("space") && !DialogManager.instance.dialogBox.activeInHierarchy) //Maybe trigger of player walks into area. to help
        {
            PlayerController.instance.canMove = false;
            DialogManager.instance.ShowDialog(lines);

        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canActivate = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canActivate = false;
        }
    }
}
