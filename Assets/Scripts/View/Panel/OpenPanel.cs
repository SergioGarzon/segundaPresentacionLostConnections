using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    public void OpenPanelVirus()
    {
        this.panel1.SetActive(false);
        this.panel2.SetActive(true);

    }
}
