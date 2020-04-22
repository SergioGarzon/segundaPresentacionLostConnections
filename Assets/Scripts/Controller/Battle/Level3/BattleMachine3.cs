using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

    public class BattleMachine3 : MonoBehaviour
    {
    /*
        public GameObject mago, hacker, virus2, virus3;

        public static bool OnPlayerTurn = true;

        //caracteristicas y el nombre
        private Unit MagoUnit;
        private Unit HackerUnit;
        private Unit Enemy2Unit;
        private Unit Enemy3Unit;

        public BattleStates states;

        public ScoreData scoreData;

        public Text dialogText;

        private int _scoreBattleEnemy = 100;

        public static bool IsPlayerChoosing = false;
        public static bool IsEnemyChoosing = false;

        // Start is called before the first frame update
        void Start()
        {
            states = BattleStates.Start;
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
            Enemy2Unit = virus2.GetComponent<Unit>();
            Enemy3Unit = virus3.GetComponent<Unit>();

            dialogText.text = "Battle 3";
            yield return new WaitForSeconds(1f);

            OnPlayerTurn = true;
        }

        IEnumerator EnemyTurn()
        {
            dialogText.text = "Enemy Turn";

            //Choose State
            IsEnemyChoosing = true;

            if (scoreData.score == 0) //el score es la vida de los players
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
            }
            else if (states == BattleStates.Lost)
            {
                dialogText.text = "You loose";
            }
        }
        */
    }


    

