using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MRandom_walk : MonoBehaviour
{
    public Animator M1Animator; 

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
            if (merchant.canBuy == false)
            {
                agent.SetDestination(GetPoint.Instance.GetRandomPoint(transform, radius));
            }
        }
        if (merchant.canBuy == false)
        {
            M1Animator.SetBool("walkking", true);
        }
        else if (merchant.canBuy == true)
        {
            M1Animator.SetBool("walkking", false);
        }
    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

#endif
}