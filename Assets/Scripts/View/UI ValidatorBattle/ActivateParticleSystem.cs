using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActivateParticleSystem : MonoBehaviour
{
    public ParticleSystem particulasRayos;
    public ParticleSystem particulasLighting;
    public ParticleSystem particulasElectricidad;
    public ParticleSystem particulasPrefab;
    public ParticleSystem particulasVirus;


    public GameObject battleSystemObjectMachine;
    private BattleMachine battleMachineObject;


    void Start()
    {

        this.battleMachineObject = this.battleSystemObjectMachine.GetComponent<BattleMachine>();
    }


    void Update()
    {
        if (this.battleMachineObject.getActivateParticles())
        {
            switch (this.battleMachineObject.getParticleActivator())
            {                
                case 9:
                    this.particulasLighting.Play();
                    break;
                case 10:
                    this.particulasElectricidad.Play();
                    break;
                case 11: particulasVirus.Play();  
                    break;
                default:
                    this.particulasRayos.Play();
                    break;
            }

            this.battleMachineObject.setActivateParticles(false);
        }
    }
        

}
