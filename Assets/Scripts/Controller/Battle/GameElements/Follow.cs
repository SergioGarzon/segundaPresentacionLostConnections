using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject _hacker;
    
    public float distance = 1f;
    public float angle = -20;

    void Update()
    {
        var playerTransform = _hacker.transform;

        Vector3 targetPosition1 = playerTransform.position + Quaternion.AngleAxis(angle,Vector3.up) * (-playerTransform.forward) * distance;

        transform.position = targetPosition1;
    }

}
//sistema de joints 
//gravity hook
//lanzar la soga
//mejor si llega
//y en cierto punto explota
//soga no infinita
//si se suelta pierde

