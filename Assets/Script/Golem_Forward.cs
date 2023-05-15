using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Forward : BaseSoState
{
    Goleam goleam;
    int inputDirection;
    

    
    public override void Enter(ControlAble controller)
    {
        base.Enter(controller);
        goleam = (Goleam)controller;
       inputDirection = (int)goleam.gameInput.lastInput;
        controller.Core.movement.RB.constraints = RigidbodyConstraints2D.FreezeRotation;


    }

    public override void Exit(ControlAble controller)
    {
        base.Exit(controller);
        
    }

    public override void UpdateState(ControlAble controller)
    {
        base.UpdateState(controller);
        goleam.animator.Play("run");
        controller.Core.movement.CheckIfShouldFlip(inputDirection);
        goleam.Core.movement.SetVelocityX(inputDirection * 4f);


    }
}
