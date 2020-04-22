using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class Virus2Controller : Virus
{
    private Vector3 _initialPosition;
    
    private bool _isNear; //cercania
    private bool _playerAttack; // algún ataque fuerte
    
    [SerializeField] private MovementVirus2 _movementVirus2;

    private readonly IddleState _iddle = new IddleState();
    private readonly ShootingState _shooting = new ShootingState();
    private readonly DieState _die = new DieState();
    private readonly BlockingState _blocking = new BlockingState();
    private readonly StealingState _stealing = new StealingState();
    
    private void Start() {
        SwitchState(_iddle, _movementVirus2);
        this.transform.position = _initialPosition;
    }

    void VirusInTurn()
    {
        if (_isNear)
        {
            SwitchState(_shooting, _movementVirus2);
            Debug.Log("2-Shoot");
            CanAttack = false; 
        }

        else if (_playerAttack==true)
        {
            SwitchState(_blocking, _movementVirus2);
            CanAttack = false; 
            Debug.Log("2-Blocking");
        }
        else if(_playerAttack==false)
        {
            SwitchState(_stealing, _movementVirus2);
            CanAttack = false; 
            Debug.Log("2-Steal");
        }
        else
        {
            SwitchState(_iddle, _movementVirus2);
            CanAttack = true;
            Debug.Log("2-Iddle");
        }
    }
    // Update Inis called once per frame

    protected override void Update()
    {
        base.Update();
        
        VirusInTurn();
    }

    
}
