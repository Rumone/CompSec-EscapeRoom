using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text dialogText;
    public GameObject dialogBox;

    public string[] dialogLines;

    public int currentLine;

    public static DialogManager instance;
    private bool justStartered;
    // Start is called before the first frame update
    void Start()
    {
       
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        dialogText.text = dialogLines[currentLine];
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogBox.activeInHierarchy)
        {
            if(Input.GetKeyUp("space"))
            {

                if(!justStartered)
                {
                    currentLine++;

                    if (currentLine >= dialogLines.Length)
                    {
                        PlayerController.instance.canMove = true;
                        dialogBox.SetActive(false);
                    }
                    else
                    {
                        dialogText.text = dialogLines[currentLine];
                    }
                }
                else
                {
                    justStartered = false;
                }
        
            }
        }
    }

    public void ShowDialog(string[] newLines)
    {
        dialogLines = newLines;

        currentLine = 0;

        dialogText.text = dialogLines[0];
        dialogBox.SetActive(true);

        justStartered = true;
    }
}
