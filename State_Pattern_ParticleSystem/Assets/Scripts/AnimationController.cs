using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public Animator FireAnim;
    public Animator CircleAnim;
    public IAnimation m_Anim;

    private void Awake()
    {
        m_Anim = new StandingAnim();
        
    }

    // Update is called once per frame
    void Update()
    {
        m_Anim.Execute(this);
    }
}
