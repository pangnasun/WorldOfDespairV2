using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villa1Top1Controller : MonoBehaviour
{
    private Animator animator;
    private bool stopState;
    
    //private bool state = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        stopState = true;
    }

    // Update is called once per frame
    public void OnPointerClick()
    {
        //Debug.Log("click");
        //Debug.Log(state);
        //Debug.Log(IsPlaying(animator, "Villa1Top1Anim"));
        //if (IsPlaying(animator, "Villa1Top1Anim"))
        //{

        //    animator.ResetTrigger("Play");
        //    animator.SetTrigger("Stop");
        //}
        //else
        //{
        //    animator.SetTrigger("Play");

        //}

        if (animator.GetFloat("AnimSpeed") == 0f && stopState)
        {
            stopState = false;
            //animator.ResetTrigger("Play");
            animator.SetFloat("AnimSpeed", 1f);
            animator.SetTrigger("Play");
        }
        //else if(animator.GetFloat("AnimSpeed") == 0f)
        //{
         
        //    animator.SetFloat("AnimSpeed", 1f);
        //    animator.SetTrigger("Play");
        //}
        else if(animator.GetFloat("AnimSpeed") == 1f)
        {
            stopState = true;
            animator.SetFloat("AnimSpeed", 0f);
            animator.SetTrigger("Stop");
        }
        

        
    }

    void Update()
    {
        if (IsDone(animator, "BLayer.Villa1Top1Anim") && !stopState)
        {
            
            stopState = true;
            animator.SetFloat("AnimSpeed", 0f);
            animator.SetTrigger("Stop");
        }

       


    }



    //public void OnPointerExit()
    //{
    //    if (animator.IsInTransition(1)) {
    //    }
    //    else
    //    {
    //        animator.SetTrigger("Stop");

    //    }




    //}

    bool IsDone(Animator anim, string stateName)
    {
        if (anim.GetCurrentAnimatorStateInfo(1).IsName(stateName) &&
                anim.GetCurrentAnimatorStateInfo(1).normalizedTime > 0.999f)
            return true;
        else
            return false;
    }
}
