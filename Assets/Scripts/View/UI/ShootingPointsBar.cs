using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ShootingPointsBar : MonoBehaviour
{
    [SerializeField] private int _allShPoints;
    public Text shootingPointsText;
    public Image shootBar;
    private ScoreData _scoreData;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_allShPoints == _scoreData.shootingPoints)
        {
            shootBar.fillAmount = _scoreData.shootingPoints / _allShPoints;
            shootingPointsText.text = (Convert.ToInt32(100 * shootBar.fillAmount)).ToString() + "%";
        }
    }
}

