using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelBattleUIAccess : MonoBehaviour
{
    public GameObject panelBattleUI;
    public Camera camaraOneOpenWorld;
    public Camera cameraTwoBattle;

    void Start()
    {
        this.SetearDatos();
    }


    private void SetearDatos()
    {
        this.panelBattleUI.SetActive(true);
        this.camaraOneOpenWorld.gameObject.SetActive(false);
        this.cameraTwoBattle.gameObject.SetActive(true);
    }


    
}
