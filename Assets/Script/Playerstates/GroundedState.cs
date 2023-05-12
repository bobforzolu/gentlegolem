using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "States", menuName = "Unique Ability/ Portal/ grounded")]

public class GroundedState : BaseSoState
{

    Girl girl;
    protected int Xinputl;

    public override void Enter(ControlAble PlayerController)
    {
        base.Enter(PlayerController);
        girl= PlayerController.GetComponent<Girl>();
   
            
    }


    public override void Exit(ControlAble PlayerController)
    {
        base.Exit(PlayerController);
    }

    public override void UpdateState(ControlAble PlayerController)
    {
        Xinputl = (int)girl.input.GetMovementVectorNoarmalized();
         

    }
}
