using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "States", menuName ="Universal States/ Walk")]
public class Walk : GroundedState
{ 

    
    public override void Enter(ControlAble PlayerController)
    {
        base.Enter(PlayerController);


       // PlayerController.animationController.EnableAnimation(PlayerController.animationController.run);

    }

    public override void Exit(ControlAble PlayerController)
    {
        base.Exit(PlayerController);
     //   PlayerController.animationController.DisableAnimation(PlayerController.animationController.run);


        PlayerController.Core.movement.SetVelocityX(0);

    }

    public override void UpdateState(ControlAble PlayerController)
    {
        base.UpdateState(PlayerController);
        if (isExitingState)
        {
            return;

        }

        PlayerController.Core.movement.CheckIfShouldFlip(Xinputl);
        PlayerController.Core.movement.SetVelocityX(PlayerController.dataDirectory.movement.movementvelocity * Xinputl);
      //  if( == 0)
        {
           // PlayerController.StateMachine.ChangeState(PlayerController.idle, PlayerController);
        }
    }
    
}
