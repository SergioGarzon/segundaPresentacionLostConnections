using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingState : State
{
    public override void InitState() {
        Debug.Log("Blocking State");
        new WaitForSecondsRealtime(5);
    }

    public override void UpdateState(float delta){
    
    }

    public override void ExitState() {
        
    }
}