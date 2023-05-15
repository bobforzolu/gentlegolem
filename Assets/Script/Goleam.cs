using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goleam : ControlAble
{
    public Golem_Idle idle;
    public Golem_Stop golem_Stop;
    public Golem_Forward golem_Forward;
    public GameInput gameInput { get; private set; }
    public Animator animator { get; private set; }
    private GoleamSpech speech ;
    private bool bossidle;
    private void Awake()
    {
        LoadData();
        idle = ScriptableObject.CreateInstance<Golem_Idle>();
        golem_Forward = ScriptableObject.CreateInstance<Golem_Forward>();
        golem_Stop = ScriptableObject.CreateInstance<Golem_Stop>();
        animator = GetComponent<Animator>();
        gameInput = GameObject.FindGameObjectWithTag("Player").GetComponent<GameInput>();


    }


    void Start()
    {
        speech= GetComponent<GoleamSpech>();
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
        if(gameInput.lastInput != 0 )
        {
            speech.playAnimation("run");
            soStatemachine.ChangeState(golem_Forward, this);
            
        }
        else 
        {
            
            soStatemachine.ChangeState(idle, this);

            speech.playAnimation("idle");

        }
    }

    private void Stop_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if(soStatemachine.CurrentPlayerState == idle)
        {
            soStatemachine.ChangeState(golem_Stop, this);
            speech.playAnimation("cut connection");


        }
        else if (soStatemachine.CurrentPlayerState ==  golem_Forward)
        {
            bossidle= true;
            soStatemachine.ChangeState(golem_Stop, this);
            speech.playAnimation("cut connection");


        }
        else if (soStatemachine.CurrentPlayerState == golem_Stop)
        {
            bossidle = true;
            soStatemachine.ChangeState(idle, this);
            speech.playAnimation("idle");


        }

    }
    private void OnDestroy()
    {
        gameInput.inputActions.Player.Stop.performed -= Stop_performed;
        gameInput.inputActions.Player.CommandForward.performed -= CommandForward_performed;
    }
}
