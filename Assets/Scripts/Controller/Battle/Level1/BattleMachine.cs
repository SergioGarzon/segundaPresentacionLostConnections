using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;



public enum BattleStates { 
    Start, 
    PlayerSelection, 
    SkillSelection, 
    EnemySelection, 
    Enemyturn, 
    EnemySelect, 
    EnemySelectPlayer, 
    Won, 
    Lost 
}


//start=comienza la batalla
//player selection= para elegir con cual atacar
//skillselection= para elegir ataque 
//enemyselection= para elegir virus a atacar 
//enemy tur= virus elije ccn cual atacar 
//enemy select= Virus elije ataque 
//enemy select player = elije a que jugador atacar 
public class BattleMachine : MonoBehaviour
{
    public GameObject mago, hacker, virus1, virus2;

    private Player _player;
    public static BattleMachine Instance;

    public static bool OnPlayerTurn = true;

    public BattleStates states;

    private bool _battle = true;

    public ScoreData scoreData;

    private Virus1 _virus1System;
    private Hacker _hackerSystem;
    private Mago _magoSystem;

    public Text dialogText;

    private int _scoreBattleEnemy = 100;
    private int _damage;

    public static bool IsPlayerChoosing = false;
    public static bool IsEnemyChoosing = false;

    public GameObject collisionZone2;
    private StartLevel2 _startLevel2;

    private CharacterController1 _characterController1;
    public int lifeBattleVirus1 = 100;
    public int lifeBattleVirus2 = 100;

    public bool isEnemySelected;
    public bool virus1Choosed = false;
    public bool virus2Choosed = false;
    private int c = 2;

    private bool lostGame;
    private int numberParticle;

    private int activateButtonState;
    private int botonPresionado;

    private bool activateParticles;
    private int activateParticlesType;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        _characterController1 = GetComponent<CharacterController1>();
        states = BattleStates.Start;
        _startLevel2 = collisionZone2.GetComponent<StartLevel2>();
        StartCoroutine(SetUpBattle());


        this.lostGame = false;
        this.activateButtonState = 0;
        this.botonPresionado = 0;
        this.numberParticle = 0;
        this.activateParticles = false;
        this.activateParticlesType = 0;

        Debug.Log("Aqui ingresa a la Battle Machine");


    }

    void Update()
    {
        switch (states)
        {
            case BattleStates.Start:
                Debug.Log("Entra al estado START");
                this.setActivateButtonStatePlayerEnemy(1);
                break;

            case BattleStates.PlayerSelection:
                CodePlayerSelection();                
                break;
                

            case BattleStates.SkillSelection:
                CodeKillSelection();                
                break;

            case BattleStates.EnemySelection:
                CodeEnemySelection();
                break;

            case BattleStates.Enemyturn:
                CodeEnemyTurn();
                //c++;

                break;
            case BattleStates.EnemySelect:
                CodeEnemySelect();
                //states = BattleStates.EnemySelect;  //Esto lo puse yo para probar
                break;


            case BattleStates.EnemySelectPlayer:
                CodeEnemySelectPlayer();
                break;

            default: break;
        }
        /*  if (OnPlayerTurn)
          {
              states = BattleStates.PlayerTurn;
              StartCoroutine(PlayerTurn());
          }
          else if (!OnPlayerTurn)
          {
              states = BattleStates.Enemyturn;
              StartCoroutine(EnemyTurn());
          }*/
    }

    IEnumerator SetUpBattle()
    {
        dialogText.text = "SetUp Battle";
        yield return new WaitForSeconds(1f);

        dialogText.text = "Battle 1";
        yield return new WaitForSeconds(1f);

        states = BattleStates.PlayerSelection;
    }


    void EndBattle()

    {
        if (states == BattleStates.Won)
        {
            dialogText.text = "You won the battle!";
            _characterController1.GoBackCity();
            _startLevel2.enabled = true;

        }
        else if (states == BattleStates.Lost)
        {
            dialogText.text = "You loose";
            this.lostGame = true;
        }
    }

    void RestScore()
    {

        if (virus1Choosed)
        {
            lifeBattleVirus1 = lifeBattleVirus1 - _damage;
            virus1Choosed = false;
        }
        else if (virus2Choosed)
        {
            lifeBattleVirus2 = lifeBattleVirus2 - _damage;
            virus2Choosed = false;
        }
    }



    private void CodePlayerSelection()
    {
        if (Input.GetKeyDown(KeyCode.H) || this.botonPresionado == 1)
        {
            Player.IsHackerPlaying = true;
            dialogText.text = "You selected hacker";
            states = BattleStates.EnemySelection;


        }
        else if (Input.GetKeyDown(KeyCode.E) || this.botonPresionado == 2)
        {
            dialogText.text = "You selected mago";
            Player.IsMagoPlaying = true;
            states = BattleStates.EnemySelection;
        }

    }

    private void CodeKillSelection()
    {
        if (Player.IsMagoPlaying)
                {

                    this.setActivateButtonStatePlayerEnemy(4);


                    if (this.botonPresionado == 12)
                    {
                        Player.IsHackerPlaying = false;
                        Player.IsMagoPlaying = false;
                        this.setActivateButtonStatePlayerEnemy(1);
                        states = BattleStates.PlayerSelection;                        
                    }

                    if (this.botonPresionado == 8)
                    {
                        _damage = 5;
                        // _states.Pixeling();
                        Debug.Log("pixel");
                        Player.IsMagoPlaying = false;
                        RestScore();
                        states = BattleStates.Enemyturn;

                        activateParticles = true;
                        activateParticlesType = 8;

                    }
                    else if (this.botonPresionado == 9)
                    {
                        _damage = 10;
                        //_states.Electricity();
                        Debug.Log("Electricity");
                        Player.IsMagoPlaying = false;
                        //Mago.Instance._electricityLimit--;
                        RestScore();
                        states = BattleStates.Enemyturn;

                        activateParticles = true;
                        activateParticlesType = 9;
                    }
                    else if (this.botonPresionado == 10)
                    {
                        //_states.Light();
                        Debug.Log("Light");
                        _damage = 15;
                        Player.IsMagoPlaying = false;
                        RestScore();
                        states = BattleStates.Enemyturn;
                        //scoreData.shootingPoints = 0;
                        activateParticles = true;
                        activateParticlesType = 10;
                    }
                    if (lifeBattleVirus1 <= 0 && lifeBattleVirus2 <= 0)
                    {
                        states = BattleStates.Won;
                    }


                }
                else if (Player.IsHackerPlaying)
                {

                    this.setActivateButtonStatePlayerEnemy(3);

                    if (this.botonPresionado == 12)
                    {
                        Player.IsHackerPlaying = false;
                        Player.IsMagoPlaying = false;
                        this.setActivateButtonStatePlayerEnemy(1);
                        states = BattleStates.PlayerSelection;
                    }

                    if (this.botonPresionado == 5)
                    {
                        _damage = 5;
                        Debug.Log("1");
                        states = BattleStates.Enemyturn;


                        activateParticles = true;
                        activateParticlesType = 5;
                    }
                    else if (this.botonPresionado == 6)
                    {
                        _damage = 10;
                        Debug.Log("2");
                        Hacker.Instance._damage = 10;
                        states = BattleStates.Enemyturn;

                        activateParticles = true;
                        activateParticlesType = 6;
                    }
                    else if (this.botonPresionado == 7)//añadir condicion 
                    {
                        _damage = 15;
                        Debug.Log("3");
                        states = BattleStates.Enemyturn;

                        activateParticles = true;
                        activateParticlesType = 7;
                    }

                }
    }


    private void CodeEnemyTurn()
    {
        //c = (int) UnityEngine.Random.Range(1, 2);

        if (c % 2 == 0)
        {

            Virus1 virus1Controller = virus1.GetComponent<Virus1>();
            Enemy.IsVirus1Playing = true;
            states = BattleStates.EnemySelect;
            //states = BattleStates.Enemyturn;
        }
        else
        {
            this.dialogText.text = ("Enemy 2 Selected");
            Virus1 virus2Controller = virus2.GetComponent<Virus1>();
            Enemy.IsVirus1Playing = true;
            states = BattleStates.EnemySelect;
            //states = BattleStates.Enemyturn;
        }

        c = 2;
    }

    private void CodeEnemySelect()
    {
        RandomState.StateLimits = 3;
        RandomState.RandomStateMethod();
        this.dialogText.text = ("Virus is choosing");
        switch (RandomState.StateE)
        {
            case 1:
                //_states.Attack();
                _damage = 5;
                Enemy.IsVirus1Playing = false;
                states = BattleStates.EnemySelectPlayer;
                break;
            case 2:
                //_states.Attack();
                _damage = 10;
                Enemy.IsVirus1Playing = false;
                states = BattleStates.EnemySelectPlayer;
                break;
            case 3:
                //_states.Scanner();
                _damage = 15;
                Enemy.IsVirus1Playing = false;
                states = BattleStates.EnemySelectPlayer;
                break;
            default:
                Enemy.IsVirus1Playing = false;
                break;
        }
    }

    private void CodeEnemySelection()
    {
        this.dialogText.text = "Select an anemy to attack";


        this.setActivateButtonStatePlayerEnemy(2);

        if (this.botonPresionado == 12)
        {
            Player.IsHackerPlaying = false;
            Player.IsMagoPlaying = false;
            this.setActivateButtonStatePlayerEnemy(1);
            states = BattleStates.PlayerSelection;
        }

        if (this.botonPresionado == 3)
        {
            this.dialogText.text = ("Attack to Virus 1");
            virus1Choosed = true;
            states = BattleStates.SkillSelection;
        }

        else if (this.botonPresionado == 4)
        {
            this.dialogText.text = ("Attack to Virus 2");
            virus2Choosed = true;
            states = BattleStates.SkillSelection;
        }
        if (lifeBattleVirus1 <= 0 & lifeBattleVirus2 <= 0)
        {
            states = BattleStates.Won;
            EndBattle();
        }
    }

    private void CodeEnemySelectPlayer()
    {
        if (RandomState.StateE % 2 == 0)
        {
            scoreData.hLife = scoreData.hLife - _damage;
            states = BattleStates.PlayerSelection;
            this.setActivateButtonStatePlayerEnemy(1);

            activateParticles = true;
            activateParticlesType = 11;

        }
        else
        {
            //Aqui modifique
            scoreData.mLife = scoreData.mLife - Virus1.Instance._damage;
            states = BattleStates.PlayerSelection;
            this.setActivateButtonStatePlayerEnemy(1);

            activateParticles = true;
            activateParticlesType = 11;
        }


        //Le ponemos un OR exclusivo
        if (scoreData.hLife <= 0 || scoreData.mLife <= 0) //el score es la vida de los players
        {
            states = BattleStates.Lost;
            EndBattle();
        }
    }

    public float[] getValueBattle()
    {
        float[] vector = new float[4];

        vector[0] = this.scoreData.hLife;
        vector[1] = this.scoreData.mLife;
        vector[2] = this.lifeBattleVirus1;
        vector[3] = this.lifeBattleVirus2;

        return vector;
    }

    public bool getLostGame()
    {
        return lostGame;
    }


    public void setActivateButtonStatePlayerEnemy(int valor)
    {
        Debug.Log("Ingresa aqui y le da el valor de " + valor);
        this.activateButtonState = valor;
    }


    public int getActivateButtonStatePlayerEnemy()
    {
        return this.activateButtonState;
    }

    public void setBotonPresionado(int valor)
    {
        this.botonPresionado = valor;
    }

    public int getParticleActivator()
    {
        return this.activateParticlesType;
    }


    public bool getActivateParticles()
    {
        return this.activateParticles;
    }

    public void setActivateParticles(bool seteoValor)
    {
        this.activateParticles = seteoValor;
    }


}


