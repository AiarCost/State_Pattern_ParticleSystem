using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingAnim : IAnimation
{
    public void Enter(AnimationController AnimCont)
    {
        AnimCont.m_Anim = this;
        AnimCont.FireAnim.SetBool("Ducking", true);
    }

    public void Execute(AnimationController AnimCont)
    {


        if (!Input.GetKey(KeyCode.S))
        {
            AnimCont.FireAnim.SetBool("Ducking", false);

            StandingAnim standing = new StandingAnim();
            standing.Enter(AnimCont);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ExpandingAnim expand = new ExpandingAnim();
            expand.Enter(AnimCont);
        }
    }



}
