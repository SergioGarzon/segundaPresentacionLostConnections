using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class CharacterController1 : MonoBehaviour
{

    //Aca trae el objeto del panal
    [SerializeField] private Transform _panalBattle;

    //aca trae la posicion del mago por medio del mesh agent
    [SerializeField] private Transform _magoBattlePosition;

    //Aca trae la posicion inicial
    [SerializeField] private Transform _initialPosition;


    //Aca trae el objeto texto para mostrar por mensaje
    public Text dialogText;
    

    //Acá trae el Scriptable object de ScoreData
    public ScoreData scoreData;

    //Acá trae el objeto Mago
    public GameObject mago;

    //Acá trae la clase SimpleMovement del player
    private SimpleMovement _simpleMovement;

    //Acá trae el objeto NavMesh del Player
    private FollowOne _followOne;

    //
    public NavMeshAgent _navMeshAgent;


    
    //////////////////////////////////////////////////////    
    //Acá trae el objeto panel de la batalla
    public GameObject panelBattleUI;

    public GameObject camara1;
    public GameObject camara2;
    //Esto de acá se va a activar en la UI de este Script
    //////////////////////////////////////////////////////    



    //public GameObject panelAutorizacion;





    // Start is called before the first frame update
    void Start()
    {
        //Lo que haces aqui es referenciar el objeto simple movimiento
        _simpleMovement = GetComponent<SimpleMovement>();

        //Aca lo que hace es traer la posicion del MAGO
        _followOne = mago.GetComponent<FollowOne>();

        //Aca lo que hace es traer la posicion actual del objeto
        _navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
    }


    //Acá cuando colisiona con el teleport
    private void OnTriggerEnter(Collider other)
    {
        //bool validar = false;

        //Aca deshabilita primero el navmeshAgent del objeto player
        _navMeshAgent.enabled = false;

        //Acá trae la aceleracion actual del objeto
        float currentaceleration=_navMeshAgent.acceleration;
        

        //Acá lo que hace es comparar si vos colisionas con el Teleport, y por medio de esto, vas
        //a cambiar las coordenadas arriba del techo
        if (other.gameObject.CompareTag("Teleport1") )
        {
            //validar = this.validarAutorizacion();

            //if (!validar) return;

            //if(validar)
            //{
                Debug.Log("Hasta aqui llega excelente");
                transform.position = _panalBattle.position;
                mago.transform.position = _magoBattlePosition.position;
                _simpleMovement.enabled = false;
                _followOne.enabled = false;

                this.camara1.SetActive(false);
                this.camara2.SetActive(true);
                this.panelBattleUI.SetActive(true);
            //}
            



        }
        /*else if (other.gameObject.CompareTag("GoBack"))
        {
            Debug.Log("ola we");
            transform.position = _initialPosition.position;
            
        }*/

        //if(validar)
        //{
            _simpleMovement.speed = 0;
            _navMeshAgent.acceleration = 0f;
            _navMeshAgent.enabled = true;
            _simpleMovement.speed = 15;
            _navMeshAgent.acceleration = currentaceleration;
        //}
        
    }

    /*private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("LifeTree"))
        {
            dialogText.text = "Score ++";
            scoreData.score = scoreData.score++;
            Debug.Log("life tree");
        }
    }*/

    public void GoBackCity()
    {
        _navMeshAgent.enabled = false;
        float currentaceleration=_navMeshAgent.acceleration;
        transform.position = _initialPosition.position;
        mago.transform.position = _initialPosition.position;
        _simpleMovement.enabled = true;
        _followOne.enabled = true;
        
        _simpleMovement.speed=0;
        _navMeshAgent.acceleration = 0f;
        _navMeshAgent.enabled = true;
        _simpleMovement.speed=15;
        _navMeshAgent.acceleration = currentaceleration;
    }

    /*
    private bool validarAutorizacion()
    {
        int valor = PlayerPrefs.GetInt("ValorGuardadoTarjeta", 0);

        if (valor != 2)
        {
            this.panelAutorizacion.SetActive(true);
            return false;
        }

        return true;
    }*/
}
