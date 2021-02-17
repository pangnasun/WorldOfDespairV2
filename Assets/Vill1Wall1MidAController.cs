using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vill1Wall1MidAController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void OnPointerEnter()
    {
        animator.SetTrigger("Play");

    }

    public void OnPointerExit()
    {
        animator.SetTrigger("Stop");


    }
}
