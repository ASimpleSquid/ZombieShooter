using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttackState : ZombieStates
{
    GameObject followTarget;
    float attackRange = 2;

    int movementZhash = Animator.StringToHash("MovementZ");
    int isAttackinghash = Animator.StringToHash("IsAttacking");

    public ZombieAttackState(GameObject _followTarget, ZombieComponent zombie, ZombieStateMachine stateMachine) : base(zombie, stateMachine)
    {
        followTarget = _followTarget;
        updateInterval = 2;

        //Set damageable Object here, ADD LATER
    }

    // Start is called before the first frame update
    public override void Start()
    {
        //base.Start()
        ownerZombie.zombieNavMeshAgent.isStopped = true;
        ownerZombie.zombieNavMeshAgent.ResetPath();
        ownerZombie.zombieAnimator.SetFloat(movementZhash, 0);
        ownerZombie.zombieAnimator.SetBool(isAttackinghash, true);
    }

    // Update is called once per frame
    public override void IntervalUpdate()
    {
        base.IntervalUpdate();
        //Deal Damage Every Interval ADD LATER
    }

    public override void Update()
    {
        //base.Update();

        ownerZombie.transform.LookAt(followTarget.transform.position, Vector3.up);

        float distanceBetween = Vector3.Distance(ownerZombie.transform.position, followTarget.transform.position);
        if (distanceBetween > attackRange)
        {
            //change state to following here
            stateMachine.ChangeState(ZombieStateType.Following);
        }
    }

    public override void Exit()
    {
        base.Exit();
        ownerZombie.zombieNavMeshAgent.isStopped = false;
        ownerZombie.zombieAnimator.SetBool(isAttackinghash, false);
    }
}
