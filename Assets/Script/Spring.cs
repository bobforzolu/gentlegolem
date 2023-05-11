using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public GameObject Rock;
    public GameObject lunchlocation;
    public bool lunch;
    public float speed = 15;
    private void Start()
    {
        lunch= false;
    }
    void cahngeangle()
    {
        float? angle = CalcultateAngle(true);
        if (angle!= null) 
        {
            Rock.transform.eulerAngles = new Vector3(0f,0f, 360f - (float)angle);

        }
    }
    float? CalcultateAngle(bool low)
    {
        Vector2 targetDIR = lunchlocation.transform.position - this.transform.position;
        float y = targetDIR.y;
        targetDIR.y = 0;
        float x = targetDIR.magnitude;
        float gravity = 9.81f;
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
        else
        {
         cahngeangle();

        }
    }
    public void MoveProjectile()
    {
        Rock.GetComponent<Rigidbody2D>().AddForce(speed * Rock.transform.forward,ForceMode2D.Impulse);
    }
}