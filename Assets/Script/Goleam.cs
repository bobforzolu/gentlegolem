using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goleam : ControlAble
{
    private Rigidbody2D Rb;
    private void Awake()
    {
        LoadData();
        
    }
    void Start()
    {
      Rb=  Rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        soStatemachine.CurrentPlayerState.UpdateState(this);
    }
}
