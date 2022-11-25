using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator animator;
    public Transform player;
    public float checkDistance = 10.0f;
    public float walkCheckDistance = 5.0f;
    public float enemyEyesAngle = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Vector3.Angle(direction, transform.forward);

        if (Vector3.Distance(player.position, transform.position) < checkDistance)
        {
            direction.y = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            if (direction.magnitude > walkCheckDistance)
            {
                transform.Translate(0, 0, 0.05f);
                animator.SetBool("isWalking", true);
                animator.SetBool("isIdle", false);
                animator.SetBool("isAttacking", false);
                animator.SetBool("isHitting", false);
                animator.SetBool("isDead", false);
            }
            else
            {

                if (Input.GetMouseButtonDown(0))
                {
                    animator.SetBool("isWalking", false);
                    animator.SetBool("isIdle", false);
                    animator.SetBool("isAttacking", false);
                    animator.SetBool("isHitting", true);
                    animator.SetBool("isDead", true);
                }
                else
                {
                    animator.SetBool("isWalking", false);
                    animator.SetBool("isIdle", false);
                    animator.SetBool("isAttacking", true);
                    animator.SetBool("isHitting", false);
                    animator.SetBool("isDead", false);
                }
            }
        }
        else
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("isWalking", false);
            animator.SetBool("isAttacking", false);
            animator.SetBool("isHitting", false);
            animator.SetBool("isDead", false);
        }
    }
}
