using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayTime : MonoBehaviour
{
    private float _timeCounter;
    private float _time; //Limit of time
    public Text timeText;
    public Text endTime;

// Start is called before the first frame update
    void Start()
    {
        _timeCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (_timeCounter <= _time)
        {
            _timeCounter = _timeCounter + Time.deltaTime;
            timeText.text = "time of game:"+ _timeCounter;
        }
        else
        {
            timeText.text = "time of game:"+ _timeCounter;
            endTime.text = "Time Out!";
            //endLevel()
        }

    }
}
