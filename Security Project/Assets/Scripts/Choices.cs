using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choices : MonoBehaviour
{
    public GameObject DialogScreen;
    public GameObject Tree;
    public GameObject TextBox;

    public GameObject Choice1;
    public GameObject Choice2;
    public GameObject Choice3;
    public GameObject Choice4;
    public GameObject Choice5;
    public GameObject Choice6;
    public GameObject Choice7;
    public GameObject Choice8;
    public GameObject badChoices;
    public GameObject goodChoices;
    public Image timerBar;
    public int ChoiceMade = 0;

    public GameObject answer1;

    public int ratioCount;

    public bool isDone;
    public bool canActivate;

    // Start is called before the first frame update
    void Start()
    {
        ratioCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(ChoiceMade == 1)
        {
            StartCoroutine(Answer1());
            ChoiceMade = 0;
        }

        if(ChoiceMade == 2)
        {
            StartCoroutine(Answer2());
            ChoiceMade = 0;
        }

        if (ChoiceMade == 3)
        {
            StartCoroutine(Answer3());
            ChoiceMade = 0;
        }

        if(ChoiceMade == 4)
        {
            StartCoroutine(Answer4());
            ChoiceMade = 0;
        }

        if (ChoiceMade == 5)
        {
            StartCoroutine(Answer5());
            ChoiceMade = 0;
        }

        if (ChoiceMade == 6)
        {
            StartCoroutine(Answer6());
            ChoiceMade = 0;
        }

        if (ChoiceMade == 7)
        {
            StartCoroutine(Answer7());
            ChoiceMade = 0;
        }

        if (ChoiceMade == 8)
        {
            StartCoroutine(Answer8());
            ChoiceMade = 0;
        }

        if(isDone == true)
        {
            CheckCount();
        }

        if(canActivate == true && isDone != true)
        {
            DialogScreen.SetActive(true);
            PlayerController.instance.canMove = false;
        }
       
    }

    public void CheckCount()
    {
        if (ratioCount >= 2)
        {
            badChoices.SetActive(true);
            timerBar.fillAmount = timerBar.fillAmount - .1f;
        }
        else
        {
            goodChoices.SetActive(true);
        }
    }

    public void ChoiceOption1()
    {
        ChoiceMade = 1;
    }

    public void ChoiceOption2()
    {
        ChoiceMade = 2;
    }

    public void ChoiceOption3()
    {
        ChoiceMade = 3;

    }


    public void ChoiceOption4()
    {
        ChoiceMade = 4;
    }

    public void ChoiceOption5()
    {
        ChoiceMade = 5;
    }

    public void ChoiceOption6()
    {
        ChoiceMade = 6;
    }

    public void ChoiceOption7()
    {
        ChoiceMade = 7;
    }

    public void ChoiceOption8()
    {
        ChoiceMade = 8;
    }
    //--------------------------------------------------------
    public IEnumerator Answer1()
    {
        TextBox.GetComponent<Text>().text = "That's great.";
        print("Hello from Answer1 script");
        Choice1.gameObject.SetActive(false);
        Choice2.gameObject.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        RoundOne();

    }

    public IEnumerator Answer2()
    {
        TextBox.GetComponent<Text>().text = "Not much for words are you.";
        Choice1.gameObject.SetActive(false);
        Choice2.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        RoundOne();
    }
    void RoundOne()
    {
        TextBox.GetComponent<Text>().text = "So you were able to get the password for the computer? What was it?";
        
        Choice3.gameObject.SetActive(true);
        Choice4.gameObject.SetActive(true);
    }
    //--------------------------------------------------------
    

    public IEnumerator Answer3()
    {
        TextBox.GetComponent<Text>().text = "Ah, yes of course.";
        Choice3.gameObject.SetActive(false);
        Choice4.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        ratioCount += 1;
        RoundTwo();


    }

    public IEnumerator Answer4()
    {
        TextBox.GetComponent<Text>().text = "Fine, dont tell me Bill";
        Choice3.gameObject.SetActive(false);
        Choice4.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        RoundTwo();
    }

    void RoundTwo()
    {
        TextBox.GetComponent<Text>().text = "So what did the email say exactly?";

        Choice5.gameObject.SetActive(true);
        Choice6.gameObject.SetActive(true);
    }
    //--------------------------------------------------------
    public IEnumerator Answer5()
    {
        TextBox.GetComponent<Text>().text = "What? She just had it in the open? I told her- Um, I mean";
        Choice5.gameObject.SetActive(false);
        Choice6.gameObject.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        RoundThree();
    }

    public IEnumerator Answer6()
    {
        TextBox.GetComponent<Text>().text = "Simple yet effective.";
        Choice5.gameObject.SetActive(false);
        Choice6.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        ratioCount += 1;
        RoundThree();

    }

    void RoundThree()
    {
        TextBox.GetComponent<Text>().text = "So did it contain the encryption key?";
        
        Choice7.gameObject.SetActive(true);
        Choice8.gameObject.SetActive(true);
    }
    //--------------------------------------------------------

    public IEnumerator Answer7()
    {
        TextBox.GetComponent<Text>().text = "Simple yet effective.";
        Choice7.gameObject.SetActive(false);
        Choice8.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        ratioCount += 1;
        RoundFour();
    }

    public IEnumerator Answer8()
    {
        //That makes sense since Barbara had access to confidential data she would know better than to put such information in an email
        TextBox.GetComponent<Text>().text = "That makes sense since Barbara had access to confidential data";
        Choice7.gameObject.SetActive(false);
        Choice8.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        RoundFour();

    }

    void RoundFour()
    {
        TextBox.GetComponent<Text>().text = "Thanks Billy";
        Choice7.gameObject.SetActive(false);
        Choice8.gameObject.SetActive(false);

        isDone = true;

    }
    //--------------------------------------------------------

    public void closePanel()
    {
        DialogScreen.SetActive(false);
        PlayerController.instance.canMove = true;
        Tree.SetActive(false);
    }

    //--------------------------------------------------------
    //Activator

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canActivate = true;
        }
            

    }
}
