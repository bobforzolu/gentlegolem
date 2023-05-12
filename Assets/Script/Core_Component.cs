using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core_Component : MonoBehaviour
{
   protected Core core;

   protected virtual void Awake() {
       core = transform.parent.GetComponent<Core>();
       
   }
    
}
