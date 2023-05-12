using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : ControlAble
{

    public GameInput input { get; private set; }
    public Walk Walk { get; private set; }
    public Jump jump { get; private set; }
    public AIrState aIrState { get; private set; }
    private void Awake()
    {
        LoadData();
        input= GetComponent<GameInput>();
        Walk = ScriptableObject.CreateInstance<Walk>();
        jump = ScriptableObject.CreateInstance<Jump>();
        aIrState = ScriptableObject.CreateInstance<AIrState>();


    }
    void Start()
    {
        soStatemachine.Initalize(Walk, this);
    }

    // Update is called once per frame
    void Update()
    {
        Core.LogicUpdate();
        soStatemachine.CurrentPlayerState.UpdateState(this);
    }
    private void FixedUpdate()
    {
    }
}
