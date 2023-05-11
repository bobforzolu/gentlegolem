using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringColison : MonoBehaviour
{
    public GameObject item { get; private set; }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        item = collision.gameObject;
    }
}
