using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Xml.Schema;
using UnityEngine;
using Object = UnityEngine.Object;
using UnityEngine.UI;

public class Mago : MonoBehaviour
{
    [SerializeField] private KeyCode _electricityKey, _pixelKey, _LightingKey;
    public int _electricityLimit;

    public ScoreData scoreData;

    private States _states = new States();

    private int _damage;


    public static Mago Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        this._electricityLimit = 100;
    }



}