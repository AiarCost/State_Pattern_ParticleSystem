using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingAnim : IAnimation
{


    public void Enter(AnimationController AnimCont)
    {
        AnimCont.m_Anim = this;
    }

    public void Execute(AnimationController AnimCont)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //jumping
            JumpingAnim jumping = new JumpingAnim();
            jumping.Enter(AnimCont);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //Ducking
            DuckingAnim ducking = new DuckingAnim();
            ducking.Enter(AnimCont);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            //Alpha
            AlphaAnim alpha = new AlphaAnim();
            alpha.Enter(AnimCont);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Beta
            BetaAnim beta = new BetaAnim();
            beta.Enter(AnimCont);
        }
    }
}
