using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControlAble: MonoBehaviour 
{
    public SoStatemachine soStatemachine;
    public PlayerDataDirectory dataDirectory;
    public AnimationEvents animationEvents;
    public Core Core;
   public  void LoadData()
    {
        soStatemachine = new SoStatemachine();
        Core=  GetComponentInChildren<Core>();
        animationEvents = GetComponent<AnimationEvents>();
    }
    public  void LogicUpdate()
    {
   
    }
}
