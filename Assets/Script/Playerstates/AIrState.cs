using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "States", menuName = "Universal States/ airstate")]

public class AIrState : BaseSoState
{
    /**
    public bool attackInput;
    public int XInput;
    public bool isJumuping;
    public bool jumpInputStop;
    public bool dashinput;
    public bool IsGrounded;
    public bool IsSkill1;
    public bool IsSkill2;


    public override void Enter(Players PlayerController)
    {
        base.Enter(PlayerController);
        PlayerController.animationController.EnableAnimation(PlayerController.animationController.jump);


    }

    public override void Exit(Players PlayerController)
    {
        base.Exit(PlayerController);
        PlayerController.animationController.DisableAnimation(PlayerController.animationController.jump);


    }

    public override void UpdateState(Players PlayerController)
    {
        base.UpdateState(PlayerController);
        if (isExitingState)
        {
            return;

        }
        XInput = PlayerController.inputvalues.xinput;
        attackInput = PlayerController.input.attackInput;
        jumpInputStop = PlayerController.input.jumpIputStop;
        dashinput = PlayerController.inputvalues.IsDashing;
        IsGrounded = PlayerController.Core.collison_Sense.GroundCheck();
        IsSkill1 = PlayerController.inputvalues.IsSkill;
        IsSkill2 = PlayerController.input.SkillActiveInput;

        checkJumpMultiplier(PlayerController);

        if(PlayerController.Core.movement.RB.velocity.y < 0)
        {
            PlayerController.Core.movement.FasterLanding(PlayerController);
        }

        if (IsGrounded && PlayerController.Core.movement.CurrentVelocity.y < 0.01f)
        {
            PlayerController.StateMachine.ChangeState(PlayerController.idle, PlayerController);
        }
        else if (dashinput && PlayerController.dash.CheckIfCanDash(PlayerController) && PlayerController.dash.GetCanDash())
        {
             PlayerController.StateMachine.ChangeState(PlayerController.dash, PlayerController);
        }
        else if (attackInput && PlayerController.spike.CanPlayerSpike(PlayerController))
        {
            PlayerController.StateMachine.ChangeState(PlayerController.charge, PlayerController);

        }
        else if (IsSkill1)
        {
            PlayerController.input.skill_Is_Pressed();
            PlayerController.StateMachine.ChangeState(PlayerController.Skill1, PlayerController);

        }
        else if (IsSkill2)
        {
            PlayerController.input.skill_Is_Pressed();

            PlayerController.StateMachine.ChangeState(PlayerController.Skill2, PlayerController);

        }
        else
        {
            PlayerController.Core.movement.CheckIfShouldFlip(XInput);
            PlayerController.Core.movement.SetVelocityX(6 * XInput);

        }

    }
    public void SetisJumping(Players players) => isJumuping = true;

    private void checkJumpMultiplier(Players PlayerController)
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