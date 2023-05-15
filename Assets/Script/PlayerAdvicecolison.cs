using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAdvicecolison : MonoBehaviour
{
    public GameEvent Eventobject;
    public bool colisionhold;
    public GameEvent EventUNraise;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Eventobject.Raise();

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (colisionhold)
        {
            if (collision.CompareTag("Player"))
            {
                EventUNraise.Raise();

            }

        }
    }
}
