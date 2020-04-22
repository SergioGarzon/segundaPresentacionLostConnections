using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarUnPanel : MonoBehaviour
{
    public GameObject panel1;
    public void ActivarPanelSolicitado()
    {
        this.panel1.SetActive(true);
    }

    public void DesactivarPanelSolicitado()
    {
        this.panel1.SetActive(false);
    }
}
