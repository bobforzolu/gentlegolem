using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  AbilityState : BaseSoState
{
    protected bool isabilityfinish;
    protected bool actionTrigger;
    protected bool IsGrounded;

    
    public override void Enter(ControlAble PlayerController)
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

    public override void Exit(ControlAble PlayerController)
    {
        base.Exit(PlayerController);
        PlayerController.animationEvents.OnAnimationEvnts -= AnimationEvents_OnAnimationEvnts;

    }

    public override void UpdateState(ControlAble PlayerController)
    {
        base.UpdateState(PlayerController);
       
        Girl girl = (Girl)PlayerController;
        IsGrounded = PlayerController.Core.collison_Sense.GroundCheck();

        if (isabilityfinish)
        {
            if (IsGrounded)
            {
                girl.soStatemachine.ChangeState(girl.Walk, PlayerController);

            }
            else
            {
                girl.soStatemachine.ChangeState(girl.aIrState, PlayerController);

            }
        }


    }
    


}
