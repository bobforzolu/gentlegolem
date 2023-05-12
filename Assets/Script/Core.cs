using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    public Movement movement{get; private set;}
    public Collison_Sense collison_Sense{get; private set;}
   

   // public Interactions Interactions{get; private set;}

    private void Awake() {
        movement = GetComponentInChildren<Movement>();
        collison_Sense = GetComponentInChildren<Collison_Sense>();
       // Interactions = GetComponentInChildren<Interactions>();

        if(!movement){
           Debug.LogError("no movement script");
        }
        if(!collison_Sense){
            Debug.LogError("no collision sense");

        }
    }
    public void LogicUpdate(){
        movement.LogicUpdate();
    }
    public void PhysicsUpdate(){
        
    }
}
