using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dog_AI : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    public GameObject Dog;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(Dog, 0.25f);
            spawnd.NumDog = spawnd.NumDog +1;
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
    }
}
