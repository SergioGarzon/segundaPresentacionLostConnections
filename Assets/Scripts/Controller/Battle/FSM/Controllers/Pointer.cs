using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public Vector3 enemiesposition;

    public Transform enemy;

    public int position = 0, initialPosition = 1;

    public Vector2 einitialPosition;

    public int noPosition = -1;//posicion prohibida
    // Start is called before the first frame update
    public void OnEnable()
    {
        if (noPosition == 0)
        {
            position = 1;
        }
        else
        {
            if (noPosition == 1)
            {
                position = 0;
            }
            transform.position=new Vector3(transform.position.x, enemiesposition.y, transform.position.y);
        }
    }

    void Start()
    {
        enemiesposition[0] = enemy.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
