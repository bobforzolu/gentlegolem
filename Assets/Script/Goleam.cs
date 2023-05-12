using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goleam : ControlAble
{
    public Golem_Idle idle;
    public Golem_Stop golem_Stop;
    public Golem_Forward golem_Forward;
    private GameInput gameInput;
    private bool bossidle;
    private void Awake()
    {
        LoadData();
        idle = ScriptableObject.CreateInstance<Golem_Idle>();
        golem_Forward = ScriptableObject.CreateInstance<Golem_Forward>();
        golem_Stop = ScriptableObject.CreateInstance<Golem_Stop>();
        gameInput = GameObject.FindGameObjectWithTag("Player").GetComponent<GameInput>();


    }


    void Start()
    {
        bossidle = true;
        soStatemachine.Initalize(idle, this);
        gameInput.inputActions.Player.Stop.performed += Stop_performed;
        gameInput.inputActions.Player.CommandForward.performed += CommandForward_performed;
    }

    // Update is called once per frame
    void Update()
    {
        Core.LogicUpdate();
        soStatemachine.CurrentPlayerState.UpdateState(this);
    }
    private void CommandForward_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if(bossidle)
        {
            bossidle = false;
            soStatemachine.ChangeState(golem_Forward, this);
            
            return;
        }
        else
        {
            bossidle = true;
            soStatemachine.ChangeState(idle, this);


        }
    }

    private void Stop_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if(bossidle)
        {
            soStatemachine.ChangeState(golem_Stop, this);
            bossidle= false;
            return;

        }
        else
        {
            bossidle= true;
            soStatemachine.ChangeState(idle, this);

        }
    }
}
