using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public PlayerController pc;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (animator != null)
        {
            if (Input.GetKeyDown(pc.jumpKey))
            {
                animator.SetTrigger("Jumping");
            }

            if (pc.grounded)
            {
                animator.SetBool("OnGround", true);
            }
            else
            {
                animator.SetBool("OnGround", false);
            }
        }
    }
}