using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GamePointsBar : MonoBehaviour
{
    public Image gamePointsBar;
    public Text gamePointsText;
    private ScoreData _scoreData;
    [SerializeField] private int _allGamePoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_allGamePoints >= _scoreData.shootingPoints)
        {
            gamePointsBar.fillAmount = _scoreData.gamePoints/ _allGamePoints;
            gamePointsText.text = (Convert.ToInt32(100 * gamePointsBar.fillAmount)).ToString() + "%";
        }
        
    }
}
