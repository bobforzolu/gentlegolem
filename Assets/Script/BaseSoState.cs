using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class  BaseSoState : ScriptableObject
{
    //checks if the state is exiting
    protected bool isExitingState;
    protected float startTime;
    /**
     * enters the state
     */
    public virtual  void Enter(ControlAble controller)
    {
        startTime = Time.time;
        
        isExitingState = false;
    }
    /**
     * updates the current state
     */
    public virtual void UpdateState(ControlAble controller)
    {

    }
    /**
    * exits the current state
    */
    public virtual void Exit(ControlAble controller)
    {
        isExitingState = true;
    }

 

   
}
