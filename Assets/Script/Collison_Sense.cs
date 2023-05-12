using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison_Sense : Core_Component
{
    [SerializeField]
    public Transform GroudCheckPosition;
    public PlayerDataDirectory playerData ;
   
    protected override void Awake()
    {
        base.Awake();

    }

    public bool GroundCheck(){
        return Physics2D.OverlapCircle(GroudCheckPosition.position, playerData.movement.GroundCheck_Radius,playerData.movement.ground);
    }
    public bool Ladder()
    {
        return Physics2D.OverlapCircle(GroudCheckPosition.position, playerData.movement.GroundCheck_Radius, playerData.movement.ground);
    }


    public void OnDrawGizmos() {
        Gizmos.DrawWireSphere(GroudCheckPosition.position, playerData.movement.GroundCheck_Radius);
    }

}
