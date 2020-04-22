using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MagoController : CharacterController
{
    /*
    private int  _electricityLimit;

    private ScoreData _scoreData;

    private SimpleMovement _movement;
    
    private readonly ElectricityState _electricity = new ElectricityState();
    private readonly PixelingState _pixeling = new PixelingState();
    private readonly LightningState _lightning = new LightningState();
    private readonly DieState _die = new DieState();
    private readonly IddleState _iddle = new IddleState();

    [SerializeField] private KeyCode _electricityKey, _pixelKey, _LightingKey;
    // Start is called before the first frame update
    void Start()
    {
        SwitchState(new IddleState());
        Debug.Log("Mago-Iddle");
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if (Input.GetKey(_pixelKey))
        {
            PixelOnClick();
        }
        else if (Input.GetKey(_electricityKey) && _electricityLimit > 0)
        {
            ElecOnClick();
        }
        else if (Input.GetKey(_LightingKey)&&_scoreData.shootingPoints==100)
        {
            LightOnClick();
        }
        else
        {
            SwitchState(_iddle, _movement);
            Debug.Log("Mago-Iddle");
            CanPlay = true;
        }

    }

    void ElecOnClick()
    {
        SwitchState(_electricity, _movement);
        _electricityLimit--;
        CanPlay = false;
        //Battle.ChangeTurn();
        Debug.Log("Mago-electricity");
    }

    void PixelOnClick()
    {
        SwitchState(_pixeling, _movement);
        //Battle.ChangeTurn();
        CanPlay = false;
        Debug.Log("Mago-pixel");
    }

    void LightOnClick()
    {
        SwitchState(_lightning, _movement);
        _scoreData.shootingPoints = 0;
        //Battle.ChangeTurn();
        CanPlay = false;
        Debug.Log("Mago-light");
    }*/
}
