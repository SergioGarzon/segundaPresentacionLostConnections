using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AccessBattlePanal : MonoBehaviour
{
    [SerializeField] private Transform panelBattle; //Objeto de la posicion del player en batalla
    [SerializeField] private Transform magoBattlePosition; //Objeto de la posicion del mago en batalla
    [SerializeField] private Transform initialPosition;  //Objeto posicion inicial

    public GameObject objetoMago;
    //private SimpleMovement movimientoSimple;
    private FollowOne seguirMagoAPlayer;
    //private NavMeshAgent navMeshPlayer;
    public GameObject objetoActivarBattleMachine;

    public GameObject playerPersonaje;

    private bool activatePanelUIBattle;
    private bool activatePanelAccessNoAutorized;

    public GameObject panelEnergyFalta;
    public ScoreData scoreData;

    void Start()
    {
        //this.movimientoSimple = this.GetComponent<SimpleMovement>();
        this.seguirMagoAPlayer = this.objetoMago.GetComponent<FollowOne>();
        //this.navMeshPlayer = this.gameObject.GetComponent<NavMeshAgent>();

        //this.movimientoSimple = this.playerPersonaje.GetComponent<SimpleMovement>();
        

        this.activatePanelUIBattle = false;
        this.activatePanelAccessNoAutorized = false;
    }



    public void OnCollisionEnter(Collision other)
    {


        //this.navMeshPlayer.enabled = false; //Deshabilito el NavMesh

        //float actualAceleracion = this.navMeshPlayer.acceleration;

        Debug.Log("Antes de la colision llega");

        if (other.gameObject.CompareTag("Teleport1"))
        {
            Debug.Log("Despues de la colision no llega");


            if (ValidadorTarjetaAcceso())
            {
                Debug.Log("Entra para validar la tarjeta de acceso");

                if (this.scoreData.mLife == 0 && this.scoreData.mLife == 0)
                {
                    Debug.Log("Valida la energia");

                    this.panelEnergyFalta.gameObject.SetActive(true);
                }
                else
                {
                    Debug.Log("Hay energia entra a la batalla");


                    this.activatePanelUIBattle = true;
                    this.activatePanelAccessNoAutorized = false;
                    this.objetoActivarBattleMachine.gameObject.SetActive(true);



                    this.SetearDatos();

                }
            }
            else
            {
                this.activatePanelUIBattle = false;
                this.activatePanelAccessNoAutorized = true;
            }

        }


        if(this.ValidadorTarjetaAcceso())
        {
            //this.movimientoSimple.speed = 0;
            //this.navMeshPlayer.acceleration = 0f;
            //this.navMeshPlayer.enabled = true;

            //this.movimientoSimple.speed = 15;
            //this.navMeshPlayer.acceleration = actualAceleracion;
        }
        

    }

    public void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Teleport1"))
        {            
            this.activatePanelAccessNoAutorized = false;
            this.panelEnergyFalta.gameObject.SetActive(false);
        }
    }

    private void SetearDatos()
    {
        //Acá lo que hago es setear las posiciones del player y mago
        this.transform.position = panelBattle.position;
        this.objetoMago.transform.position = this.magoBattlePosition.position;
        
        //Deshabilita el movimiento del player y el mago
        //this.movimientoSimple.enabled = false;
        this.seguirMagoAPlayer.enabled = false;
    }

    public bool RetornarActivacionPanelUIBattle()
    {
        return this.activatePanelUIBattle;
    }


    public bool RetornarValorActivacionPanel()
    {
        return this.activatePanelAccessNoAutorized;
    }

    private bool ValidadorTarjetaAcceso()
    {
        int valor = PlayerPrefs.GetInt("ValorGuardadoTarjeta", 0);
        bool resultado = false;

        if (valor != 2) resultado = false;
        if (valor == 2) resultado = true;    

        return resultado;
    }

}
