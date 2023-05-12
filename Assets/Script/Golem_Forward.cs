using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Forward : BaseSoState
{
    Goleam goleam;
    int facingDirection;

    
    public override void Enter(ControlAble controller)
    {
        base.Enter(controller);
        goleam = (Goleam)controller;
    }

    public override void Exit(ControlAble controller)
    {
        base.Exit(controller);
        
    }

    public override void UpdateState(ControlAble controller)
    {
        base.UpdateState(controller);
    }
}
