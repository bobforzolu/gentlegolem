using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "States", menuName = "Universal States/ jump")]

public class Jump : AbilityState
{
    /**
    public override void Enter(Players PlayerController)
    {
        base.Enter(PlayerController);
        PlayerController.Core.movement.SetJumpVelocityY(PlayerController.dataDirectory.movement.JumpForce);
        isabilityfinish = true;
        PlayerController.airstate.SetisJumping(PlayerController);
        
    }
    public override void Exit(Players PlayerController)
    {
        base.Exit(PlayerController);


    }

    public override void UpdateState(Players PlayerController)
    {
        base.UpdateState(PlayerController);

    }
    **/
}
