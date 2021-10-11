using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaAnim : IAnimation
{

    public void Enter(AnimationController AnimCont)
    {
        AnimCont.m_Anim = this;
        AnimCont.FireAnim.SetBool("Alphaing", true);
    }

    public void Execute(AnimationController AnimCont)
    {
        if (!Input.GetKey(KeyCode.E))
        {
            AnimCont.FireAnim.SetBool("Alphaing", false);

            StandingAnim standing = new StandingAnim();
            standing.Enter(AnimCont);
        }
    }
}
