using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport: MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Tree");
        }
    }
}