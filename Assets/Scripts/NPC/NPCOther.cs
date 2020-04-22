using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCOther : MonoBehaviour
{
    public GameObject dialogPanelNPC;
    public GameObject buttonPanelNPC;
    private Text dialogText;
    private string _textNpc;
    private int _counter = 0;
    private Button[] options;
    private int optionNumber = 0;

    private void Start()
    {
        dialogText = dialogPanelNPC.GetComponentInChildren<Text>(); 
        options =buttonPanelNPC.GetComponentsInChildren<Button>();
        options[0].GetComponentInChildren<Text>().text = "Ignore";
        options[1].GetComponentInChildren<Text>().text="No";
        options[2].GetComponentInChildren<Text>().text="Really?";
        
        options[0].onClick.AddListener((() => FirtFuncion()));
        options[1].onClick.AddListener((() => SecondFuncion()));
        options[2].onClick.AddListener((() => ThirdFuncion()));
        
    }

    void OnMouseDown()
    {
        Debug.Log("It works!");
        _counter++;
        ChooseText();
        StartCoroutine(ShowDialogText());
    }
    IEnumerator ShowDialogText()
    {
        dialogPanelNPC.SetActive(true);
        dialogText.text = _textNpc;

        if (_counter == 2)
        {
            buttonPanelNPC.SetActive(true);
            yield return new WaitUntil((() => optionNumber!=0)); 
            dialogText.text = _textNpc;
            yield return new WaitForSeconds(3f);
            dialogPanelNPC.SetActive(false);
            buttonPanelNPC.SetActive(false);
            optionNumber = 0;
        }
        else
        {
            yield return new WaitForSeconds(3f);
            dialogPanelNPC.SetActive(false);
            
        }
    }
    void ChooseText()
    {
        if (_counter == 1)
        {
            _textNpc = "Before the explosion it used to be a very beautiful place";
        }
        else if (_counter == 2)
        {
            _textNpc = " Now there is even an illegal market, can you believe it?";
        }
        else if (_counter >= 3)
        {
            if (_counter % 2 == 0)
            {
                _textNpc = "The end is near!";
            }
            else
            {
                _textNpc = "Be very careful!";
            }
            
        }
    }

    void FirtFuncion()
    {
        if (_counter == 2)
        {
            _textNpc = "Youth is lost";
            optionNumber = 1;
            Debug.Log("Yes"); 
        }
    }
    void SecondFuncion()
    {
        if (_counter == 2)
        {
            optionNumber = 2; 
            _textNpc = "Yes, it is near of here";
            Debug.Log("gg");  
        }
    }
    void ThirdFuncion()
    {
        if (_counter == 2)
        {
            optionNumber = 3;
            _textNpc = "Yes...take this to buy you something";
            Debug.Log("Yes, take this"); 
        }
    }
    
}
