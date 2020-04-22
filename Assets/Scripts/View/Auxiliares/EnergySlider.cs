using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergySlider : MonoBehaviour
{
    public Slider sldEnergyPrincipal;
    public Slider sldEnergySecondary;
    public Slider sldEnergyVirus1;
    public Slider sldEnergyVirus2;

    private bool bandera;


    void Start()
    {
        this.bandera = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F8))
        {
            this.bandera = true;
        }

        if(bandera)
        {
            this.sldEnergyPrincipal.value += 0.1f;
            this.sldEnergySecondary.value += 0.1f;
            this.sldEnergyVirus1.value += 0.1f;
            this.sldEnergyVirus2.value += 0.1f;

        }
        
    }


}
