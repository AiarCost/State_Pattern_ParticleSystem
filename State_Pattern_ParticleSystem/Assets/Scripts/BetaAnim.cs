using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetaAnim : IAnimation
{
    public void Enter(AnimationController AnimCont)
    {
        AnimCont.m_Anim = this;
        AnimCont.FireAnim.SetBool("Betaing", true);
    }

    public void Execute(AnimationController AnimCont)
    {
        if (!Input.GetKey(KeyCode.Q))
        {
            AnimCont.FireAnim.SetBool("Betaing", false);

            StandingAnim standing = new StandingAnim();
            standing.Enter(AnimCont);
        }
    }
}
