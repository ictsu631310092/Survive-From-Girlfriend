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
    int i;

    public AudioClip sfxshesay; //เชื่อมเสียงกระสูน
    public AudioClip sfxsheiscome;
    public AudioSource sfxAudioSource_shesay;
    public AudioSource sfxAudioSource_shecome;//เชื่องเสียง

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
            i = 0;
        }
        if (FieldOfView1.canSeePlayer == false)
        {
            GFAnimator.SetBool("walkking", true);
        }
        else if (FieldOfView1.canSeePlayer == true)
        {
            GFAnimator.SetBool("walkking", false);
        }
        if (FieldOfView1.canSeePlayer == true)
        {
            for (i = 0; i < 2; i++)
            {
                sfxAudioSource_shesay.PlayOneShot(sfxshesay);
            }
            sfxAudioSource_shecome.PlayOneShot(sfxsheiscome);
        }
    }
}
