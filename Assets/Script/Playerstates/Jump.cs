using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "States", menuName = "Universal States/ jump")]

public class Jump : AbilityState
{
    
    public override void Enter(ControlAble PlayerController)
    {
        base.Enter(PlayerController);
        Girl girl = (Girl)PlayerController;
        PlayerController.Core.movement.SetJumpVelocityY(PlayerController.dataDirectory.movement.JumpForce);
        isabilityfinish = true;
      //  girl.aIrState.SetisJumping(PlayerController);
        
    }
    public override void Exit(ControlAble PlayerController)
    {
        base.Exit(PlayerController);


    }

    public override void UpdateState(ControlAble PlayerController)
    {
        base.UpdateState(PlayerController);

    }
    
}
