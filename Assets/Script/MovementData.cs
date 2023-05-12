using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu ( fileName = "MovementData", menuName ="Data/Player Data/Movement Data")]
public class MovementData : ScriptableObject
{
    [Header("Movestate")]
    public float movementvelocity = 10f;

    [Header("jumpSpeed")]
    public float JumpForce = 10f;

    [Header ("checks")]
    public float GroundCheck_Radius = 1f;
    public LayerMask ground;
    public LayerMask ladder;


    [Header("in Air State ")]
    public float variablesJumpHeight = 0.4f;
    [Header("dash state")]
    public float dashCoolDown = 50f;
    public float dashTime =0.25f;
    public float dashInteruptTime = 0.1f;
    public float dashVelocity = 30f;
    public float drag = 10f;
    public float dashEndYMultiplier = 0.2f;


    [Header(" gravity modifier")]
    public float fallMultipier = 2.5f;
    public float GravityModifier = 1.7f;
    public float GravityDisableTime = 0.1f;

  



}
