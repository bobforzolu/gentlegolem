using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControlAble: MonoBehaviour 
{
    public SoStatemachine soStatemachine;
   public  void LoadData()
    {
        soStatemachine = new SoStatemachine();
    }
    public  void LogicUpdate()
    {
   
    }
}
