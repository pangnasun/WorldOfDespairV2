using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villa1TopMideA20Controller : MonoBehaviour
{
    private Animator animator;
    private bool stopState;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        stopState = true;
    }

    public void OnPointerClick()
    {


        if (animator.GetFloat("AnimSpeed") == 0f && stopState)
        {
            stopState = false;
            animator.SetFloat("AnimSpeed", 1f);
            animator.SetTrigger("Play");
        }
        else if (animator.GetFloat("AnimSpeed") == 1f)
        {
            stopState = true;
            animator.SetFloat("AnimSpeed", 0f);
            animator.SetTrigger("Stop");
        }



    }

    void Update()
    {
        if (IsDone(animator, "BLayer.Villa1TopMidA20Anim") && !stopState)
        {
           
            stopState = true;
            animator.SetFloat("AnimSpeed", 0f);
            animator.SetTrigger("Stop");
        }




    }


    bool IsDone(Animator anim, string stateName)
    {
        if (anim.GetCurrentAnimatorStateInfo(1).IsName(stateName) &&
                anim.GetCurrentAnimatorStateInfo(1).normalizedTime > 0.999f)
            return true;
        else
            return false;
    }
}
