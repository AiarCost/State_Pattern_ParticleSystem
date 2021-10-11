using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingAnim : IAnimation 
{

    public void Enter(AnimationController AnimCont)
    {
        AnimCont.m_Anim = this;
        AnimCont.FireAnim.SetBool("Jumping", true);

    }

    public void Execute(AnimationController AnimCont)
    {
        if (IsAnimPlaying(AnimCont.FireAnim, "Jumping State"))
            AnimCont.FireAnim.SetBool("Jumping", false);
            

        if(!IsAnimPlaying(AnimCont.FireAnim, "Jumping State"))
        {
            AnimCont.FireAnim.speed = 1f;
            StandingAnim standing = new StandingAnim();
            standing.Enter(AnimCont);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Diving (Faster run of the animation)

            AnimCont.FireAnim.speed = 5f;
        }

        
    }

    bool IsAnimPlaying(Animator anim, string stateName)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName(stateName) &&
                anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }
}
