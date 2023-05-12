using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public GameObject Rock;
    public GameObject lunchlocation;
    public bool lunch;
    public bool low;
    public float speed = 15;
    private SpringColison c;
    private void Start()
    {
        c= GetComponentInChildren<SpringColison>();
        c.OnRockTrigger += C_OnRockTrigger;
        
    }

    private void C_OnRockTrigger(object sender, SpringColison.OnRockTriggerArgs e)
    {
        Rock = e.Rock;
        lunch = e.start;
    }

    void cahngeangle( GameObject rock)
    {
        float? angle = CalcultateAngle(low,rock);
        if (angle!= null) 
        {
            rock.transform.eulerAngles = new Vector3(0f,0f, 360f - (float)angle);

        }
    }
    float? CalcultateAngle(bool low, GameObject rock)
    {
        Vector2 targetDIR = lunchlocation.transform.position - rock.transform.position;
        float y = targetDIR.y ;
        targetDIR.y = 0;
        float x = targetDIR.magnitude - 1;
        float gravity = 9.8f;
        float sSqr = speed* speed;
        float underTheSQR = (sSqr * sSqr)- gravity* (gravity*x*x+2*y * sSqr);

        if (underTheSQR >= 0f)
        {
            float root = Mathf.Sqrt(underTheSQR);
            float highAngle = sSqr + root;
            float lowAngle = sSqr - root;

            if (low)
            {
                return Mathf.Atan2(lowAngle, gravity * x) * Mathf.Rad2Deg;
            }
            else
                return Mathf.Atan2(highAngle, gravity * x) * Mathf.Rad2Deg;
        }
        else
            return null;

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
        cahngeangle(Rock);
        Rock.GetComponentInChildren<Rigidbody2D>().velocity =(speed * Rock.transform.up);
    }
}