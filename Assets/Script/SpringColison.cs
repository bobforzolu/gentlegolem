using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringColison : MonoBehaviour
{
    public GameObject item { get; private set; }

   
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        item = collision.gameObject;
    }
}
