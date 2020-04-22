using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSelectPlayerAttack : MonoBehaviour
{
    public GameObject objetoActivadorBotones;
    public HabilitarBotones botones;


    void Start()
    {
        this.botones = this.objetoActivadorBotones.GetComponent<HabilitarBotones>();
    }

    public void SelectHacker()
    {
        this.botones.ActivarCharlie();
    }

    public void SelectAtif()
    {
        this.botones.ActivarAtif();
    }

    public void SelectVirusOne()
    {
        this.botones.ActivarVirusAtacar1();
    }

    public void SelectVirusTwo()
    {
        this.botones.ActivarVirusAtacar2();
    }


    public void SelectPowerBug()
    {
        this.botones.ActivarAtaquePrimerPersonaje(5);
    }

    public void SelectPowerSteel()
    {
        this.botones.ActivarAtaquePrimerPersonaje(6);
    }
    

    public void SelectPowerPixel()
    {
        this.botones.ActivarAtaquePrimerPersonaje(7);
    }

    public void SelectPowerShock()
    {
        this.botones.ActivarAtaquePrimerPersonaje(8);
    }

    public void SelectPowerLighting()
    {
        this.botones.ActivarAtaquePrimerPersonaje(9);
    }

    public void SelectPowerElectricity()
    {
        this.botones.ActivarAtaquePrimerPersonaje(10);
    }

    public void SelectBackMenuInitialButtons()
    {
        this.botones.ActivarAtaquePrimerPersonaje(12);
    }


}



