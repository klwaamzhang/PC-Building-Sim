using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public enum States { Patrol, Chase, Attack };
    States currentState = States.Patrol;

    Transform player;

    //variables

    public float ChaseDistance = 5; //if distance to NPC < ChaseDistance => Chase
    public float AttackDistance = 2; //if distance to NPC < AttackDistance => Attack
    public bool isPlayerBehind = false;
    public bool isPlayerHidden = false;

    public GameObject healthController;
    public int removeAmount = -20;
    

    //Sep 18th
    float chasingSpeed = 1.5f; //1 ms/s

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        FSM();
    }

    //States

        private void ChangeState(States toState)
    {
        currentState = toState;
    }

    private void Patrol()
    {
        //Debug.Log("Patrolling");

        if (Vector3.Distance(transform.position, player.position) <= ChaseDistance)
        {
            ChangeState(States.Chase);
        }
    }

    private void Chase()
    {
        //Debug.Log("Chasing");
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceToPlayer <= AttackDistance)
        {
            ChangeState(States.Attack);
        }
        else if(distanceToPlayer > ChaseDistance)
        {
            ChangeState(States.Patrol);
        }
        Vector3 directionToPlayer = player.position - transform.position;
        float distanceSpeed = chasingSpeed * Time.deltaTime;
        Vector3 newPosition = transform.position + (distanceSpeed * directionToPlayer.normalized);
        transform.position = newPosition;
        transform.LookAt(player);
    }

    private void Attack()
    {
        //Debug.Log("Attack");
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (isPlayerHidden || distanceToPlayer > ChaseDistance)
        {
            ChangeState(States.Patrol);
        }
        else if (distanceToPlayer > AttackDistance)
        {
            ChangeState(States.Chase);
        }
        
    }

    private void FSM()
    {
        switch (currentState)
        {
            case States.Patrol:
                Patrol();
                break;
            case States.Chase:
                Chase();
                break;
            case States.Attack:
                Attack();
                break;
            default:
                Debug.Log("Error: currentState = " + currentState);
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            healthController.GetComponent<HealthController>().RemoveHealth(20);
            Debug.Log("Collision Detected!");
        }
    }
}
