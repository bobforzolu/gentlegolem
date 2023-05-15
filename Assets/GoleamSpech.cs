using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoleamSpech : MonoBehaviour
{
    // Start is called before the first frame update
    Animator speech;
    SpriteRenderer sprite;
    void Start()
    {
        speech= transform.Find("Rock Spech").GetComponent <Animator>();
        sprite= transform.Find("Rock Spech").GetComponent<SpriteRenderer>();
        sprite.enabled= false;
    }

    public void playAnimation(string animation)
    {
        sprite.enabled = true;
        speech.Play(animation);
        Invoke("stopAnimation", 1f);
    }
    public void stopAnimation()
    {
        sprite.enabled = false;
    }
    
}
