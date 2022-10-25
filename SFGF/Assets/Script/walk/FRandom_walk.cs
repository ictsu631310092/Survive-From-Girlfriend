using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FRandom_walk : MonoBehaviour
{
    public Animator F1Animator;

    private NavMeshAgent agent;

    public float radius;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (!agent.hasPath)
        {
            if (BorrowMoney.canBorrow == false)
            {
                agent.SetDestination(GetPoint.Instance.GetRandomPoint(transform, radius));
            }
        }
        if (BorrowMoney.canBorrow == false)
        {
            F1Animator.SetBool("walkking", true);
        }
        else if (BorrowMoney.canBorrow == true)
        {
            F1Animator.SetBool("walkking", false);
        }

    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

#endif
}