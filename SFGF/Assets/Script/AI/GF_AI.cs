using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GF_AI : MonoBehaviour
{
    public Animator GFAnimator;
    public NavMeshAgent enemy;
    public Transform player;
    public Transform tenemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FieldOfView1.canSeePlayer == true)
        {
            enemy.SetDestination(player.position);
        }
        else if (FieldOfView1.canSeePlayer != true)
        {

        }
        if (FieldOfView1.canSeePlayer == false)
        {
            GFAnimator.SetBool("walkking", true);
        }
        else if (FieldOfView1.canSeePlayer == true)
        {
            GFAnimator.SetBool("walkking", false);
        }
    }
}
