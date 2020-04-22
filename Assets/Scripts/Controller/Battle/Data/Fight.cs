using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{

    public static void InFight()
    {
        ScoreData _scoreData;
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                _scoreData.score=_scoreData.score+5;
            }
            else if (other.CompareTag("Player"))
            {
                _scoreData.score = _scoreData.score - 5;
            }
        }    
    }

    public class Bullet : MonoBehaviour
    {
        ScoreData _scoreData;

        private void OnCollisionEnter(Collision other)
        {
            if (CompareTag("Enemy"))
            {
                _scoreData.score=_scoreData.score+10;
            }
            else if (CompareTag("Player"))
            {
                _scoreData.score=_scoreData.score-10;
            }
        }
    }


}
