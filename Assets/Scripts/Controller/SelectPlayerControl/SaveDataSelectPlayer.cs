using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Windows.Input;

public class SaveDataSelectPlayer : MonoBehaviour
{
    public GameObject panelActivate;
    public InputField inputValueName;
    public GameObject panelInformationError;
    public Button botonHacker;
    public Button botonAlquimista;

    void Start()
    {
        this.panelActivate.SetActive(false);
        this.panelInformationError.SetActive(false);
    }


    public void ActivatePanelValidationName()
    {
        if(inputValueName.text.Equals(""))
        {
            this.panelInformationError.SetActive(true);
            this.panelActivate.SetActive(false);
        }
        else
        {            
            this.panelActivate.SetActive(true);
            this.panelInformationError.SetActive(false);

            ObjectEnabled();


        }
    }

    private void ObjectEnabled()
    {
        this.botonAlquimista.enabled = false;
        this.botonHacker.enabled = false;
        this.inputValueName.enabled = false;

    }
}
