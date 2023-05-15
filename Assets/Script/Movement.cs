using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Movement : Core_Component
{
    public Rigidbody2D RB{get; private set;}
    private Vector2 workplace;
    public int facingDirections;
    public Vector2 CurrentVelocity{get; private set;}

    private float elapsedtime;
    
    protected override void Awake()
    {
        base.Awake();
        RB = GetComponentInParent<Rigidbody2D>();
        facingDirections = 1;
    }
    public void LogicUpdate(){
        CurrentVelocity = RB.velocity;

    }
    public void FasterLanding(ControlAble playerController)
    {
       
        workplace = RB.velocity += Vector2.up * Physics2D.gravity.y * (playerController.dataDirectory.movement.fallMultipier - 1) * Time.deltaTime;
        RB.velocity = workplace;
        CurrentVelocity = workplace;

    }
   
    public void SetVelocityX(float velocity)
    {
        workplace.Set(velocity,CurrentVelocity.y);
        RB.velocity = workplace;
        CurrentVelocity = workplace;
    }
    public void SetVelocityY(float velocity)
    {
        workplace.Set(CurrentVelocity.x, velocity);
        RB.velocity = workplace;
        CurrentVelocity = workplace;
    }
    public void SetJumpVelocityY(float velocity)
    {
        workplace.Set(CurrentVelocity.x, velocity);
        RB.AddForce(workplace, ForceMode2D.Impulse);
       
    }

    public void SetVelocity(float velocity, Vector2 Direction)
    {
        workplace = Direction * velocity;
        Debug.Log(workplace);

        RB.velocity = workplace;
        CurrentVelocity = workplace;
    }
    public void SetVelocity(Vector2 velocity, Vector2 Direction)
    {
        workplace = Direction * velocity;
        RB.velocity = workplace;
        CurrentVelocity = workplace;
    }
    public void SetVelocitXY(float vx, float vy)
    {
        workplace.Set(vx, vy);
        RB.velocity = workplace;
        CurrentVelocity = workplace;

    }
    public void SetVelocity(float SpeedReduction)
    {
        workplace = CurrentVelocity * SpeedReduction;
        RB.velocity = workplace;
        CurrentVelocity = workplace ;
    }
    public Vector3 CheckIfShouldFlip(int XInput) 
    {
        if(XInput != 0 && XInput != facingDirections)
        {
            return Flip();
        }
        return new Vector3(0, 0, 0);
    }
    public void BallImpulse( float velocity,Vector2  force)
    {
      RB.AddForce(force * velocity, ForceMode2D.Impulse);
    }

    public void SetSpikeAngle(Vector2 Movement)
    {
        int xinput = (int)Movement.x;
       if( Movement.y > 0f)
        {
            RB.transform.Rotate(0, CheckIfShouldFlip(xinput).y, 35);
        }
        else if( Movement.y < 0f)
        {
            RB.transform.Rotate(0, CheckIfShouldFlip(xinput).y, -35);
        }
        else
        {
            RB.transform.Rotate(0, CheckIfShouldFlip(xinput).y, 0);
        }
    }

    public Vector3 Flip()
    {
        facingDirections *= -1;
        Vector3 rotation = new Vector3(0.0f, 180.0f, 0f);
        RB.transform.Rotate(0.0f, 180f, 0.0f);
        return rotation;
    }
    public void MoveToLocation(Vector2 p1, Vector2 p2, float duration)
    {
         elapsedtime += Time.deltaTime;
        float precentagedone = elapsedtime / duration;
        if(p1.x > p2.x)
             workplace = Vector2.Lerp(p1, p2, precentagedone);
        else
            workplace = Vector2.Lerp(p1, p2, precentagedone);

        RB.velocity = workplace;
        CurrentVelocity = workplace;
    }
    public void MoveToLocationWithLimits(Vector2 p1, Vector2 p2, float speed, float dis)
    {
        Vector2 directionToPlayer = p1 - p2;
        workplace = directionToPlayer.normalized;
        if(Vector2.Distance(p1, p2) > dis)
        {
            if(p1.x < p2.x)
            {
                 RB.velocity = new Vector2( workplace.x * speed,RB.velocity.y);

            }
            else
            {
                RB.velocity = new Vector2(workplace.x * speed,  RB.velocity.y);

            }
        }
    }


}
