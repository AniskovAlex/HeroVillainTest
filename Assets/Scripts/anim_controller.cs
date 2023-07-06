using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class anim_controller : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] SkeletonAnimation skeleton_animator;

    private void OnMouseDown()
    {
        if (animator != null)
            animator.SetTrigger("Attack");
        if (skeleton_animator != null)
        {
            skeleton_animator.AnimationState.SetAnimation(0, "sword_attack", false);
            skeleton_animator.AnimationState.AddAnimation(0, "idle_3", true, 1f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
