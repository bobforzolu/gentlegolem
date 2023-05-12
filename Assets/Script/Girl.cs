using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : ControlAble
{

    public GameInput input { get; private set; }
    public Walk Walk { get; private set; }
    private void Awake()
    {
        LoadData();
        input= GetComponent<GameInput>();
        Walk = ScriptableObject.CreateInstance<Walk>();

    }
    void Start()
    {
        soStatemachine.Initalize(Walk, this);
    }

    // Update is called once per frame
    void Update()
    {
        soStatemachine.CurrentPlayerState.UpdateState(this);
    }
}
