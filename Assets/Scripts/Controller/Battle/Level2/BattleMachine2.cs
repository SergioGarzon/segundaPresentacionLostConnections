using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class BattleMachine2 : MonoBehaviour
{

    /*
    public GameObject mago, hacker, virus3;

    public static bool OnPlayerTurn = true;
    
    //caracteristicas y el nombre
    private Unit MagoUnit; 
    private Unit HackerUnit;
    private Unit EnemyUnit;

    public BattleStates states;

    public ScoreData scoreData;

    public Text dialogText; 

    private int _scoreBattleEnemy = 100;

    public static bool IsPlayerChoosing=false;
    public static bool IsEnemyChoosing=false;

    public GameObject collisionZone3;
    private StartLevel3 _startLevel3;
    
    // Start is called before the first frame update
      void Start()
    {
        states = BattleStates.START;
        _startLevel3 = collisionZone3.GetComponent<StartLevel3>();
        StartCoroutine(SetUpBattle());
    }

    void Update() 
    {
        
        if (OnPlayerTurn)
        {
            states = BattleStates.PlayerTurn;
            StartCoroutine(PlayerTurn());
        }
        else if (!OnPlayerTurn)
        {
            states = BattleStates.Enemyturn;
            StartCoroutine(EnemyTurn());
        }
    }

    IEnumerator SetUpBattle()
    {
        dialogText.text = "SetUp Battle";
        yield return new WaitForSeconds(1f);
            
        MagoUnit = mago.GetComponent<Unit>();
        HackerUnit = hacker.GetComponent<Unit>();
        EnemyUnit = virus3.GetComponent<Unit>();

        dialogText.text = "Battle 2";
        yield return new WaitForSeconds(1f);

        OnPlayerTurn = true;
    }

    IEnumerator EnemyTurn()
    {
        dialogText.text = "Enemy Turn";
        
        //Choose State
        Virus3 virus1Controller = virus3.GetComponent<Virus3>();
        IsEnemyChoosing = true;
        
        if (scoreData.score==0) //el score es la vida de los players
        {
            states = BattleStates.Lost;
            EndBattle();
        }
        yield return new WaitForSeconds(2f);
    }

    IEnumerator PlayerTurn()
    {
        yield return new WaitForSeconds(2f);
        
        if (states != BattleStates.PlayerTurn)
        {
            yield break;
        }
        dialogText.text = "Choose a Player";
        
        //Choose a Player and Attack 
        
        IsPlayerChoosing = true;

        if (_scoreBattleEnemy == 0)
        {
            states = BattleStates.Won;
            EndBattle();
        }

        yield return new WaitForSeconds(2f);
    }
    
    void EndBattle()
    
    {
        if (states == BattleStates.Won)
        {
            dialogText.text = "You won the battle!";
            _startLevel3.enabled = true;
        }
        else if (states == BattleStates.Lost)
        {
            dialogText.text = "You loose";
        }
    }
    */
    
}