using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class AttackingState : State
{
    [SerializeField] ParticleSystem particleAttack;
    [SerializeField] private Slider slideEnergy;
    [SerializeField] Slider sliderEnergyEnemy;

    public Text texto;
    
    public override void InitState() {
        Fight.InFight();
        new WaitForSecondsRealtime(2);
    }

    public override void UpdateState(float delta)
    {
        Attack();
    }

    public override void ExitState() {
        
    }
    void Attack()
    {
        if (this.slideEnergy.value > 0f)
        {
            this.particleAttack.Play();
            this.slideEnergy.value = 0f;
            this.texto.text = "Attack";
            this.sliderEnergyEnemy.value -= 0.05f;
        }
    }
}