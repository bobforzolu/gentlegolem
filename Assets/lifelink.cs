using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifelink : MonoBehaviour
{
    public Color lineColor;
   

    private float timeOffset = 0f; // tracks the time offset for the wave animation

  


    public GameObject object1;
    public GameObject golem;
    public LineRenderer lineRenderer;

    void Start()
    {
        
        GetComponent<GameInput>().inputActions.Player.Stop.performed += Stop_performed;
        GetComponent<GameInput>().inputActions.Player.CommandForward.performed += CommandForward_performed; 
        object1 = GameObject.FindGameObjectWithTag("Player");
        golem = GameObject.FindGameObjectWithTag("Golem");
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.widthMultiplier = 0.05f;
        lineRenderer.startColor = lineColor;
        lineRenderer.endColor = lineColor;
        lineRenderer.positionCount = 2;
    }

    private void CommandForward_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        lineRenderer.enabled = true;
    }

    private void Stop_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
    }

    void Update()
    {
        if (golem.GetComponent<Goleam>().soStatemachine.CurrentPlayerState == golem.GetComponent<Goleam>().golem_Stop)
            lineRenderer.enabled = false;
        else
            lineRenderer.enabled= true;
        Vector3 midpoint = (object1.transform.position + golem.transform.position) / 2f;
        lineRenderer.SetPosition(0, new Vector3(object1.transform.position.x, object1.transform.position.y + 0.5f));
        lineRenderer.SetPosition(1, new Vector3(golem.transform.position.x, golem.transform.position.y + 0.5f));
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
    }
    private void OnDestroy()
    {
        GetComponent<GameInput>().inputActions.Player.Stop.performed -= Stop_performed;
        GetComponent<GameInput>().inputActions.Player.CommandForward.performed -= CommandForward_performed;
    }

}
