using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandingAnim : IAnimation
{
    public void Enter(AnimationController AnimCont)
    {
        AnimCont.m_Anim = this;
        AnimCont.FireAnim.SetBool("Expanding", true);
    }

    public void Execute(AnimationController AnimCont)
    {
        if (!Input.GetKey(KeyCode.Space))
        {
            AnimCont.FireAnim.SetBool("Expanding", false);

            DuckingAnim ducking = new DuckingAnim();
            ducking.Enter(AnimCont);
        }
    }
}
