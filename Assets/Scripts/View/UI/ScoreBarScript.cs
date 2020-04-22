using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ScoreBarScript : MonoBehaviour
{
    public Image scoreBar;

    public float time = 5f;//tiempo que dura

    private float timeCounter;

    public Text scoreText;

    public ScoreData scoreData;
     
    [SerializeField] private int _allScore;


     // Start is called before the first frame update
    void Start()
    {
        timeCounter = 0;
    }
    // Update is called once per frame
    void Update()
    {

        if (_allScore != scoreData.score)
        {
            scoreBar.fillAmount = scoreData.score / _allScore;
            scoreText.text = (Convert.ToInt32(100 * scoreBar.fillAmount)).ToString() + "%";
        }
    }
}
