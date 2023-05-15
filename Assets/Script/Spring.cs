using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public GameObject Rock;
    public Transform target;
    public bool lunch;
    public bool low;
    public float launchAngle = 45f;
    public float launchSpeed = 10f;
    private SpringColison c;
    Animator animator;
    private void Start()
    {
        c= GetComponentInChildren<SpringColison>();
        c.OnRockTrigger += C_OnRockTrigger;
        animator = GetComponent<Animator>();
    }

    private void C_OnRockTrigger(object sender, SpringColison.OnRockTriggerArgs e)
    {
        Rock = e.Rock;
        lunch = e.start;
    }

    void cahngeangle( GameObject rock)
    {
      
    }
   
    private void Update()
    {

        if (lunch)
        {
            lunch = false;
        MoveProjectile();

        }
    }
    public void MoveProjectile()
    {


        animator.Play("lunch");
        // Calculate distance and height difference to target
        float targetDistance = Vector2.Distance(Rock.transform.position, target.position);
        float targetHeight = target.position.y - Rock.transform.position.y;

        // Calculate launch velocity using angle and speed
        float launchVelocity = launchSpeed / Mathf.Cos(launchAngle * Mathf.Deg2Rad);
        Vector2 launchDirection = (target.position - Rock.transform.position).normalized;
        Vector2 launchVelocityVector = launchDirection * launchVelocity;

        // Calculate time of flight using quadratic formula
        float timeOfFlight = (targetDistance) / (launchVelocity * Mathf.Cos(launchAngle * Mathf.Deg2Rad));
        float maxHeight = Rock.transform.position.y + (targetHeight + Mathf.Tan(launchAngle * Mathf.Deg2Rad) * targetDistance) / 2f;

        // Instantiate rock and launch using trajectory formula
        
        Rigidbody2D rockRigidbody = Rock.GetComponentInChildren<Rigidbody2D>();
        rockRigidbody.velocity = launchVelocityVector;
        rockRigidbody.gravityScale = Mathf.Abs(Physics2D.gravity.y);
        rockRigidbody.drag = rockRigidbody.mass / (timeOfFlight * rockRigidbody.gravityScale);
        rockRigidbody.AddForce(Vector2.up * maxHeight, ForceMode2D.Impulse);
        Invoke("RevertSpring", 1f);
    }


    public void RevertSpring()
    {
        animator.Play("idle");

    }
}