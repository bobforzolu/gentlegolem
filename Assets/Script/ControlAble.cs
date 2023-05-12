using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControlAble: MonoBehaviour 
{
    public SoStatemachine soStatemachine;
    public PlayerDataDirectory dataDirectory;
    public Core Core;
   public  void LoadData()
    {
        soStatemachine = new SoStatemachine();
        Core=  Core.GetComponentInChildren<Core>();
    }
    public  void LogicUpdate()
    {
   
    }
}
