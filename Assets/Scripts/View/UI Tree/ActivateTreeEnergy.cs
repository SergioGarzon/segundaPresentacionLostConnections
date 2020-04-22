using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateTreeEnergy : MonoBehaviour
{
    public GameObject objetoPanel;
    public GameObject objetoArboles;
    public ChargeLifeTree vidaArbol;
    public Slider barraEnergia;
    public ScoreData scorePuntaje;
    private bool ActivarBarraEnergia;
    public Text textoPressE;

    void Start()
    {
        this.vidaArbol = this.objetoArboles.GetComponent<ChargeLifeTree>();
        this.RestaurarDatos();
    }


    void Update()
    {
        if (this.vidaArbol.VeracidadActivadorPanel() == 1)
        {
            this.objetoPanel.SetActive(true);


            if (Input.GetKey(KeyCode.E))
            {
                this.barraEnergia.gameObject.SetActive(true);

                this.ActivarBarraEnergia = true;

                this.scorePuntaje.mLife = 100;
                this.scorePuntaje.hLife = 100;
            }
        }


        if(this.vidaArbol.VeracidadActivadorPanel() == 2)
        {
            this.barraEnergia.gameObject.SetActive(false);
            this.objetoPanel.SetActive(false);

            this.vidaArbol.SetValorColisionActivadorPanel(0);
        }

        if (this.ActivarBarraEnergia)
            this.AumentarBarraEnergia();

        
    }


    public bool getActivarBarraEnergia()
    {
        return this.ActivarBarraEnergia;
    }

    public void RestaurarDatos()
    { 
        this.textoPressE.gameObject.SetActive(true);
        this.barraEnergia.gameObject.SetActive(false);
        this.barraEnergia.value = 0f;
    }


    private void AumentarBarraEnergia()
    {
        this.barraEnergia.value += 0.5f;

        if (this.barraEnergia.value == 100)
        {
            this.ActivarBarraEnergia = false;
            this.barraEnergia.gameObject.SetActive(false);
            this.barraEnergia.value = 0f;
        }


            
    }


}
