using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class SoStatemachine 
{
    public BaseSoState CurrentPlayerState { get; private set; }


    public void Initalize(BaseSoState state )
    {
        CurrentPlayerState = state;
       // CurrentPlayerState.Enter(controller);
    }

    public void ChangeState<T>(BaseSoState state, T controller)
    {
        CurrentPlayerState.Exit(controller);
        CurrentPlayerState = state;
        CurrentPlayerState.Enter(controller);

    }


  

}
