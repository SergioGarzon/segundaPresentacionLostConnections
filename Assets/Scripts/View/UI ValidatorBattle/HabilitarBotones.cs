using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HabilitarBotones : MonoBehaviour
{
    public Button BtnEscapeBack, BtnCharlie, BtnAtif, BtnBack, BtnBug, BtnSteal, BtnPixel,
        BtnShock, BtnLighning, BtnElectricity, BtnVirusOne, BtnVirusTwo;

    private int valorParaActivar;
    public static int valorVirusAtacado;
    private int valorRetornarActivarTexto;


    public GameObject objetoVirus1;
    public GameObject objetoVirus2;
    

    public GameObject objetoBattleMachine;
    public BattleMachine battleMachine;

    public GameObject playerObject;
    public Player clasePlayer;
    public GameObject objetoPlayer;
    public Hacker hackerDatos;
    public GameObject objetoMago;
    public Mago magoDatos;


    void Start()
    {
        this.valorRetornarActivarTexto = 0;

        this.battleMachine = this.objetoBattleMachine.GetComponent<BattleMachine>();
        this.clasePlayer = this.playerObject.GetComponent<Player>();
        this.hackerDatos = this.objetoPlayer.GetComponent<Hacker>();
        this.magoDatos = this.objetoMago.GetComponent<Mago>();
    }


    void Update()
    {
        switch(this.battleMachine.getActivateButtonStatePlayerEnemy())
        {
            case 1: BotonesIniciales(); break;
            case 2: this.PanelesVeracidadActivacion(false, false, false, true, false, false, false, false, false, false, true, true); break;
            case 3: this.PanelesVeracidadActivacion(false, false, false, true, true, true, true, false, false, false, false, false); break;
            case 4: this.PanelesVeracidadActivacion(false, false, false, true, false, false, false, true, true, true, false, false); break;
        }

    }



    public void BotonesIniciales()
    {
        Debug.Log("Entra al estado de Botones iniciales");

        if (this.objetoVirus1.activeSelf && this.objetoVirus2.activeSelf)
        {
            this.PanelesVeracidadActivacion(true, true, true, false, false, false, false, false, false, false, false, false);
        }
        else
        {
            this.PanelesVeracidadActivacion(false, false, false, false, false, false, false, false, false, false, false, false);
        }
        
    }


    public void ActivarCharlie()
    {
        ActivarBotonesVirus(1);
    }

    public void ActivarAtif()
    {
        ActivarBotonesVirus(2);
    }

    public void ActivarVirusAtacar1()
    {
        ActivarBotonesVirus(3);
    }

    public void ActivarVirusAtacar2()
    {
        ActivarBotonesVirus(4);
    }

    public void ActivarAtaquePrimerPersonaje(int valorAtaque)
    {
        this.battleMachine.setBotonPresionado(valorAtaque);
    }

    public void ActivarAtaqueSegundoPersonaje(int valorAtaque)
    {
        this.battleMachine.setBotonPresionado(valorAtaque);
    }


    private void ActivarBotonesVirus(int valor)
    {
        if (this.objetoVirus1.activeSelf || this.objetoVirus2.activeSelf)
        {
            this.battleMachine.setBotonPresionado(valor);
        }        
    }




    public void PanelesVeracidadActivacion(bool pnlEsc, bool pnlCharlie, bool pnlAtif, bool pnlBack, bool pnlBug,
        bool pnlSteal, bool pnlPixel, bool pnlShock, bool pnlLight, bool pnlElect, bool pnlVirus1, bool pnlVirus2)
    {
        this.BtnEscapeBack.gameObject.SetActive(pnlEsc);
        this.BtnCharlie.gameObject.SetActive(pnlCharlie);
        this.BtnAtif.gameObject.SetActive(pnlAtif);
        this.BtnBack.gameObject.SetActive(pnlBack);
        this.BtnBug.gameObject.SetActive(pnlBug);
        this.BtnSteal.gameObject.SetActive(pnlSteal);
        this.BtnPixel.gameObject.SetActive(pnlPixel);
        this.BtnShock.gameObject.SetActive(pnlShock);
        this.BtnLighning.gameObject.SetActive(pnlLight);
        this.BtnElectricity.gameObject.SetActive(pnlElect);
        this.BtnVirusOne.gameObject.SetActive(pnlVirus1);
        this.BtnVirusTwo.gameObject.SetActive(pnlVirus2);
    }

}
