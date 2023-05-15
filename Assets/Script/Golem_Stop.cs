using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Stop : BaseSoState
{

    Goleam goleam;

    public override void Enter(ControlAble controller)
    {
        base.Enter(controller);
        goleam = (Goleam)controller;

        controller.Core.movement.RB.constraints = RigidbodyConstraints2D.FreezeRotation;
        controller.gameObject.layer = LayerMask.NameToLayer("Ground");



    }

    public override void Exit(ControlAble controller)
    {
        base.Exit(controller);
        controller.gameObject.layer = LayerMask.NameToLayer("Golem");

        controller.Core.movement.RB.constraints = RigidbodyConstraints2D.FreezeRotation;

    }

    public override void UpdateState(ControlAble controller)
    {
        base.UpdateState(controller);
        goleam.animator.Play("gentlerock");


    }
}
