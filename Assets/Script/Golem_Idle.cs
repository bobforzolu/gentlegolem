using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem_Idle : BaseSoState
{
    public float distanceToPlayer;
    public float walkspeed;
    Goleam goleam;

    public GameObject girl;


    public bool forword;
    public override void Enter(ControlAble controller)
    {
        base.Enter(controller);
        goleam = (Goleam)controller;

        walkspeed = 2.5f;
        distanceToPlayer = 2f;
        girl = GameObject.FindGameObjectWithTag("Player");

    }

    public override void Exit(ControlAble controller)
    {
        base.Exit(controller);
    }

    public override void UpdateState(ControlAble controller)
    {
        base.UpdateState(controller);
        goleam.animator.Play("idlerock");

        controller.Core.movement.MoveToLocationWithLimits(girl.transform.position, controller.transform.position, walkspeed, distanceToPlayer);


       
    }
}
