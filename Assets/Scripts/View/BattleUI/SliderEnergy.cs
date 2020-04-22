using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderEnergy : MonoBehaviour
{
    public Slider energyPlayerCharlie;
    public Slider energyPlayerAtif;
    public Slider energyVirusOne;
    public Slider energyVirusTwo;

    public GameObject objectBattle;
    private BattleMachine batMachine;


    public GameObject virus1;
    public GameObject virus2;


    public RawImage[] imageSlider;


    void Start()
    {
        this.batMachine = this.objectBattle.GetComponent<BattleMachine>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!getLostGameBattleMachine())
            this.ActualiceSliderEnergy();


        if (this.energyVirusOne.value <= 0)
            this.virus1.gameObject.SetActive(false);

        if (this.energyVirusTwo.value <= 0)
            this.virus2.gameObject.SetActive(false);
            

    }

    private void ActualiceSliderEnergy()
    {
        float[] valor = this.batMachine.getValueBattle();
        Slider[] vectorSlider = { energyPlayerCharlie, energyPlayerAtif, energyVirusOne, energyVirusTwo };

        for (int i = 0; i < valor.Length; i++)
        {
            if (valor[i] > 0)
            {
                vectorSlider[i].value = valor[i];
            }
        }



    }


    public bool getLostGameBattleMachine()
    {
        return this.batMachine.getLostGame();
    }

    public void setComponenetesBattleUI(bool valor)
    {
        for(int i = 0; i < this.imageSlider.Length; i++)
        {
            this.imageSlider[i].gameObject.SetActive(valor);
        }
    }

}
