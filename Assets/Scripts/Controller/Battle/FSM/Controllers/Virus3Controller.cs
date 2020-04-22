using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus3Controller : Virus
{
    
    private readonly AttackingState _attacking = new AttackingState();
    private readonly DieState _die = new DieState();
    private readonly LightningState _lightning = new LightningState();
    private readonly BuggingState _bugging = new BuggingState();
    private  readonly PixelingState _pixeling = new PixelingState();
    private readonly IddleState _iddle = new IddleState();

    private GameData _gameData;
    
    [SerializeField] private MovementVirus2 _movementVirus2;
   
    // Start is called before the first frame update
    void Start()
    {
        SwitchState(_iddle, _movementVirus2);
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        RandomState.StateLimits = 4 ;
        
        
        switch (RandomState.StateE)
        {
            case 1:
                SwitchState(_attacking, _movementVirus2);
                _gameData.actualState=_attacking;
                Debug.Log("2-Attack");
                CanAttack = false;
                break;
            case 2:
                SwitchState(_pixeling, _movementVirus2);
                _gameData.actualState=_pixeling;
                Debug.Log("2-Pixel");
                CanAttack = false;
                break;
            case 3:
                SwitchState(_lightning, _movementVirus2);
                _gameData.actualState=_lightning;
                Debug.Log("2-Light");
                CanAttack = false;
                break;
            case 4:
                SwitchState(_bugging, _movementVirus2);
                _gameData.actualState=_bugging;
                Debug.Log("2-Bug");
                CanAttack = false;
                break;
            default:
                SwitchState(_iddle, _movementVirus2);
                Debug.Log("3-idle");
                CanAttack = true;
                break;
        }
    }

}
