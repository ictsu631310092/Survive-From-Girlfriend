using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dog_AI : MonoBehaviour
{
    public Animator DogAnimator;
    public NavMeshAgent enemy;
    public Transform player;
    public GameObject Dog;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(Dog, 0.01f);
            spawnd.NumDog++;
        }
    }
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FieldOfView.canSeePlayer == true)
        {
            enemy.SetDestination(player.position);
        }
        else if (FieldOfView.canSeePlayer == false)
        {

        }
        if (FieldOfView.canSeePlayer == false)
        {
            DogAnimator.SetBool("walkking", true);
        }
        else if (FieldOfView.canSeePlayer == true)
        {
            DogAnimator.SetBool("walkking", false);
        }
    }
}
