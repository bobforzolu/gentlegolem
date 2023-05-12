using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "States", menuName = "Unique Ability/ Portal/ grounded")]

public class GroundedState : BaseSoState
{

    Girl girl;
    protected int Xinputl;
    public bool Jump;
    protected bool isGrounded;

    public override void Enter(ControlAble PlayerController)
    {
        base.Enter(PlayerController);
        girl= PlayerController.GetComponent<Girl>();
        girl.input.inputActions.Player.Jump.performed += Jump_started;


    }


    public override void Exit(ControlAble PlayerController)
    {
        base.Exit(PlayerController);
        girl.input.inputActions.Player.Jump.performed -= Jump_started;

    }

    public override void UpdateState(ControlAble PlayerController)
    {
        Xinputl = (int)girl.input.GetMovementVectorNoarmalized();
        isGrounded = PlayerController.Core.collison_Sense.GroundCheck();

        if (Jump && isGrounded)
        {
            Jump= false;
            girl.soStatemachine.ChangeState(girl.jump, PlayerController);
        }
         

    }
    private void Jump_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Jump= true;
    }
   
}
