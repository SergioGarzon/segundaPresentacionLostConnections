using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergySliderCharge : MonoBehaviour
{
    public Slider EnergyPlayerOne;
    public Slider EnergyPlayerTwo;
    public Slider EnergyEnemyOne;
    public Slider EnergyEnemyTwo;

    void Start()
    {
        StartCoroutine(CorrutinaCargarEnergia());
    }

    void Update()
    {

    }

    IEnumerator CorrutinaCargarEnergia()
    {
        yield return new WaitForSeconds(100f);
        this.EnergyEnemyOne.value += 0.1f;
        this.EnergyEnemyTwo.value += 0.1f;
        this.EnergyPlayerOne.value += 0.1f;
        this.EnergyEnemyTwo.value += 0.1f;
    }

}
