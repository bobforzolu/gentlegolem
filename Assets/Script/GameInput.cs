using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerInputActions inputActions { get; private set; }
    public bool jump { get; private set; }
    public bool Command { get; private set; }
    public bool interact { get; private set; }
    private void Awake()
    {
        inputActions= new PlayerInputActions();
        inputActions.Player.Enable();
    }
    void Start()
    {
       

    }

    

    public float GetMovementVectorNoarmalized()
    {
        Vector2 inputvector = inputActions.Player.movement.ReadValue<Vector2>();
        inputvector = inputvector.normalized;
        float movement = inputvector.x;
        return movement;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
