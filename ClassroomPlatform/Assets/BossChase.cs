using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossChase : StateMachineBehaviour
{
   
    Transform player;
    Rigidbody2D rb;
    BossPosition BossPosition;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo,int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        BossPosition = animator.GetComponent<BossPosition>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        BossPosition.LookAtPlayer();
        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPosition = Vector2.MoveTowards(rb.position, target, BossPosition.speed * Time.deltaTime);
        rb.MovePosition(newPosition);
        float distance = Vector2.Distance(player.position, rb.position);

        if (distance< BossPosition.attackRange && !BossPosition.Phase2 && BossPosition.Phase3)
        {
            animator.SetTrigger("MeleeAttack");
        }
        else if (distance < BossPosition.attackRange && !BossPosition.Phase2 && BossPosition.Phase3)
        {
            animator.SetTrigger("Phase2");
        }
        else if (distance < BossPosition.attackRange && !BossPosition.Phase2 && BossPosition.Phase3)
        {
            animator.SetTrigger("Phase3");
        }
        else if (distance < BossPosition.attackRange && !BossPosition.Phase2 && BossPosition.Phase3)
        {
            animator.SetTrigger("Death");
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }


















}
