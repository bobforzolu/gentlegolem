using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "States", menuName = "Universal States/ airstate")]

public class AIrState : BaseSoState
{

    float xinput;
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
        xinput = girl.input.GetMovementVectorNoarmalized();
       

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