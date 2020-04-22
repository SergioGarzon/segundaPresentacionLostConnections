using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Virus1 : MonoBehaviour
{
    private States _states = new States();
    public int _damage;
    public ScoreData scoreData;
    public static Virus1 Instance;
    private void Awake()
    {
        Instance = this;
    }


}
