using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringColison : MonoBehaviour
{
    public GameObject item;
    public bool StartTimer;
    private Spring s;


    public event EventHandler<OnRockTriggerArgs> OnRockTrigger;
    public class OnRockTriggerArgs : EventArgs
    {
        public GameObject Rock;
        public bool start;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Golem"))
        {
            if (collision.GetComponent<Goleam>().soStatemachine.CurrentPlayerState == collision.GetComponent<Goleam>().golem_Stop) 
            {
                item = collision.gameObject;
                 StartTimer= true;
                OnRockTrigger?.Invoke(this, new OnRockTriggerArgs
                {
                    Rock = item.gameObject,
                    start = StartTimer
                }); 

            }
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        OnRockTrigger?.Invoke(this, new OnRockTriggerArgs
        {
            
            start = false
        });
    }


}
