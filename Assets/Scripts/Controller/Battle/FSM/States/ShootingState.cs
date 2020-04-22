using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingState : State
{
    private ScoreData _scoreData;

    [SerializeField] private GameObject bulletPrefab;
    private GameObject bullet;
    private GameObject enemy;
    private bool alive;
    private float shootRadius;
    private GameObject thisPlayer;

    public override void InitState()
    {
        enemy = GameObject.FindWithTag("Enemy");
        //animation
        Play();
    }

    public override void UpdateState(float delta)
    { }

    public override void ExitState()
    {
        new WaitForSecondsRealtime(5);
    }

    void Play()
    {
        float distance = Vector3.Distance(enemy.transform.position, thisPlayer.transform.position);
        if (bullet.CompareTag("Enemy"))
        {
            _scoreData.score = _scoreData.score + 5;

            if (distance < shootRadius)
            {
                _scoreData.score = _scoreData.score + 5;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(thisPlayer.transform.position, shootRadius);
    }
}