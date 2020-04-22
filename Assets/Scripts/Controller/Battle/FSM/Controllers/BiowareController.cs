using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BiowareController : CharacterController
{
    /*
    public int position;

    public int shootingPoints;

    
    [SerializeField] 
    private KeyCode _shootKey;
    private KeyCode _fightKey;
    
    private readonly ShootingState _shooting = new ShootingState();
    private readonly AttackingState _attacking = new AttackingState();
    private readonly IddleState _iddle = new IddleState();
    private readonly DieState _die = new DieState();
    public readonly FightingState _Fighting = new FightingState();

    [SerializeField] private SimpleMovement _movement; 
    

    private ScoreData _scoreData;
    // Start is called before the first frame update
    void Start()
    {
        SwitchState(_iddle, _movement);
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        if (_scoreData.shootingPoints == 100 && Input.GetKey(_shootKey))
        {
            ShootOnClick();
        }
        else if (Input.GetKey(_fightKey))
        {
            FightOnClick();
        }
        else
        {
            SwitchState(_iddle, _movement);
            Debug.Log("Iddle-Bioware");
            CanPlay = true; 
        } 
    }

    void ShootOnClick()
    {
      SwitchState(_shooting, _movement);
      _scoreData.shootingPoints = 0;
      CanPlay = false;
      Debug.Log("Bioware - Shooting");

      //pasar de turno
      //Battle.ChangeTurn();
    }

    void FightOnClick()
    {
        SwitchState(_Fighting, _movement);
        CanPlay = false;
        Debug.Log("Bioware - Fight");
        //pasar de turno//Battle.ChangeTurn();
    }*/

}
