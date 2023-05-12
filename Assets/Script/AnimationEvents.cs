using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public event EventHandler<OnAnimationEvntsArgs> OnAnimationEvnts;
    public class OnAnimationEvntsArgs: EventArgs
    {
        public bool animationFinish;
        public bool ActionTrigger;
        
    }

    private void Start()
    {
    }

    public void AnimationFinish()
    {
        OnAnimationEvnts?.Invoke(this, new OnAnimationEvntsArgs
        {
            animationFinish = true
        });
    }
    public void ActironTrigger()
    {
        OnAnimationEvnts?.Invoke(this, new OnAnimationEvntsArgs
        {
            ActionTrigger = true
        });
    }

    public void ActironTriggerDisasbled()
    {
        OnAnimationEvnts?.Invoke(this, new OnAnimationEvntsArgs
        {
            ActionTrigger = false
        });
    }


}
