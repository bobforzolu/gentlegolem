using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "States", menuName = "Universal States/ airstate")]

public class AIrState : BaseSoState
{

    float xinput;
    bool grounded;
    public override void Enter(ControlAble PlayerController)
    {
        base.Enter(PlayerController);
      //  PlayerController.animationController.EnableAnimation(PlayerController.animationController.jump);


    }

    public override void Exit(ControlAble PlayerController)
    {
        base.Exit(PlayerController);
       // PlayerController.animationController.DisableAnimation(PlayerController.animationController.jump);


    }

    public override void UpdateState(ControlAble PlayerController)
    {
        base.UpdateState(PlayerController);
        if (isExitingState)
        {
            return;

        }
        Girl girl = (Girl)PlayerController;
        xinput = girl.input.normInputY;
        grounded = PlayerController.Core.collison_Sense.GroundCheck();

       girl.Core.movement.SetVelocityX(xinput * 0.3f);

        if (grounded)
        {
            PlayerController.soStatemachine.ChangeState(girl.Walk, PlayerController);
        }
        if (PlayerController.Core.movement.RB.velocity.y < 0)
        {
            PlayerController.Core.movement.FasterLanding(PlayerController);
        }

    }
    /**
    public void SetisJumping(ControlAble players) => isJumuping = true;

    private void checkJumpMultiplier(ControlAble PlayerController)
    {

        if (isJumuping)
        {
            if (jumpInputStop)
            {
                PlayerController.Core.movement.SetVelocityY(PlayerController.Core.movement.CurrentVelocity.y * PlayerController.dataDirectory.movement.variablesJumpHeight);
                isJumuping = false;
            }
            else if (PlayerController.Core.movement.CurrentVelocity.y <= 0)
            {
                isJumuping = false;
            }

        }
    }
    **/
    
   
}