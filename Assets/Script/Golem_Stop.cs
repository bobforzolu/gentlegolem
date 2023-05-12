using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Stop : BaseSoState
{
  

    public override void Enter(ControlAble controller)
    {
        base.Enter(controller);
        controller.Core.movement.RB.constraints = RigidbodyConstraints2D.FreezeAll;
        controller.gameObject.layer = LayerMask.NameToLayer("rock");


    }

    public override void Exit(ControlAble controller)
    {
        base.Exit(controller);
        controller.gameObject.layer = LayerMask.NameToLayer("Golem");

        controller.Core.movement.SetVelocityX(0);
        controller.Core.movement.RB.constraints = RigidbodyConstraints2D.None;

    }

    public override void UpdateState(ControlAble controller)
    {
        base.UpdateState(controller);
    }
}
