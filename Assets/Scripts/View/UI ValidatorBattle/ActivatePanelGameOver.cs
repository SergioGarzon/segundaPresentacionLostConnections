using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePanelGameOver : MonoBehaviour
{
    public GameObject panelGameOver;
    public GameObject objetoGameOver;
    public BattleMachine maquinaBatalla;

    void Start()
    {
        this.maquinaBatalla = this.objetoGameOver.GetComponent<BattleMachine>();
    }

    void Update()
    {
        /*
        if(this.maquinaBatalla.getPanelGameOver())
        {
            Debug.Log("GAME OVER");
            //this.panelGameOver.gameObject.SetActive(true);
        }*/
    }
}
