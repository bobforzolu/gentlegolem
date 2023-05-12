using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  AbilityState : BaseSoState
{
    protected bool isabilityfinish;
    protected bool actionTrigger;
    protected bool IsGrounded;

    /**
    public override void Enter(Players PlayerController)
    {
        base.Enter(PlayerController);
        isabilityfinish = false;
        PlayerController.animationEvents.OnAnimationEvnts += AnimationEvents_OnAnimationEvnts;

    }

    private void AnimationEvents_OnAnimationEvnts(object sender, AnimationEvents.OnAnimationEvntsArgs e)
    {
        isabilityfinish = e.animationFinish;
        actionTrigger = e.ActionTrigger;
    }

    public override void Exit(Players PlayerController)
    {
        base.Exit(PlayerController);
        PlayerController.animationEvents.OnAnimationEvnts -= AnimationEvents_OnAnimationEvnts;

    }

    public override void UpdateState(Players PlayerController)
    {
        base.UpdateState(PlayerController);
       
        IsGrounded = PlayerController.Core.collison_Sense.GroundCheck();
        
        if (isabilityfinish)
        {
            if (IsGrounded)
            {
                PlayerController.StateMachine.ChangeState(PlayerController.idle, PlayerController);

            }
            else
            {
                PlayerController.StateMachine.ChangeState(PlayerController.airstate, PlayerController);

            }
        }


    }
    **/


}
