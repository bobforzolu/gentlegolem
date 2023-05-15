using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInput : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerInputActions inputActions { get; private set; }
    public bool jump { get; private set; }
    public bool Command { get; private set; }
    public float normInputY;
    public bool interact { get; private set; }
    public float lastInput;
    private void Awake()
    {
        inputActions= new PlayerInputActions();
        inputActions.Player.Enable();
        inputActions.Player.movement.performed += Movement_performed;
        inputActions.Player.relods.performed += Relods_performed;
    }

    private void Relods_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Reload();
    }

    private void Movement_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        
    }

    void Start()
    {
       

    }

    

    public float GetMovementVectorNoarmalized()
    {
        Vector2 inputvector = inputActions.Player.movement.ReadValue<Vector2>();
        inputvector = inputvector.normalized;
        float movement = inputvector.x;
        normInputY = (int)(inputvector * Vector2.up).normalized.y;
        if (movement != 0)
        {
            lastInput = movement;
            Invoke("ReserLasTinput", 0.4f);
        }
        Debug.Log(lastInput);
        return movement;

    }
    public void ReserLasTinput()
    {
        lastInput= 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {
        inputActions.Player.movement.performed -= Movement_performed;
        inputActions.Player.relods.performed -= Relods_performed;

    }
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
