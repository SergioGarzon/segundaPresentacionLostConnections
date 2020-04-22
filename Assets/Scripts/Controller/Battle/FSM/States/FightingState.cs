using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingState : State
{
    public override void InitState() {
        Fight.InFight();
        new WaitForSecondsRealtime(2);
    }

    public override void UpdateState(float delta) {
        
    }

    public override void ExitState() {
        
    }
}