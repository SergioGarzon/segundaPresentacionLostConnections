using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivatorPanelGameOver : MonoBehaviour
{
    public GameObject objectSlider;
    public GameObject objectPanelBattleUI;
    public GameObject objectPanelGameOver;
    private SliderEnergy sldEnergyClass;

    private bool validar;

    void Start()
    {
        this.sldEnergyClass = this.objectSlider.GetComponent<SliderEnergy>();
        this.validar = false;
    }


    void Update()
    {
        if (this.sldEnergyClass.getLostGameBattleMachine()  && !validar)
        {

            this.sldEnergyClass.setComponenetesBattleUI(false);

            this.objectPanelGameOver.gameObject.SetActive(true);
            this.objectPanelBattleUI.gameObject.SetActive(false);
            this.validar = true;
        }
    }




}
