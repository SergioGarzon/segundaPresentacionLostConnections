using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InvisibilityState : State
{
    public override void InitState() {

    }

    public override void UpdateState(float delta) {
        
    }

    public override void ExitState() {
        
    }
}

public class Invisible : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision other)
    {
        //no pasa nada, porque esta invisible y no pasa nada, el jugador no lo ve. 
    }
}