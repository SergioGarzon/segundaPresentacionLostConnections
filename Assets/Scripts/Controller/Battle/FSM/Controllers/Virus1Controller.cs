using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus1Controller : Virus
{
    private Vector3 _initialPosition;
    
    [SerializeField] private MovementVirus2 _movementVirus2;

    private readonly IddleState _iddle = new IddleState();
    private readonly AttackingState _attacking = new AttackingState();
    private readonly DieState _die = new DieState();
    private readonly InvisibilityState _invisibility = new InvisibilityState();
    private readonly ScannerState _scanner = new ScannerState();
    
    private void Start() {
        SwitchState(_iddle, _movementVirus2);
        this.transform.position = _initialPosition;
    }

    protected override void Update()
    {
        base.Update();
        
        RandomState.StateLimits =3 ;
                 
                 
                 switch (RandomState.StateE)
                 {
                     case 1:
                         SwitchState(_invisibility, _movementVirus2);
                         Debug.Log("2-Invisibility");
                         CanAttack = false;
                         break;
                     case 2:
                         SwitchState(_attacking, _movementVirus2);
                         Debug.Log("2-Attack");
                         CanAttack = false;
                         break;
                     case 3:
                         SwitchState(_scanner, _movementVirus2);
                         Debug.Log("2-Scanner");
                         CanAttack = false;
                         break;
                     default:
                         SwitchState(_iddle, _movementVirus2); 
                         CanAttack = true;
                         break;
                 }

    }
}