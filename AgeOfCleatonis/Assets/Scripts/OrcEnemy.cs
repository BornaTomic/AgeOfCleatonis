using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcEnemy : Enemy
{
    public Transform target;
    public float attackRadius;
    public float chaseRadius;

    //public Transform homePosition;
    private Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemyState.idle;
        anime = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        DistanceCheck();
    }

    void DistanceCheck()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            if (currentState == EnemyState.idle)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                StateChange(EnemyState.walk);
            }

            else
            {
                StateChange(EnemyState.idle);
            }
        }
    }

    private void StateChange(EnemyState newState)
    {
        if (currentState != newState)
        {
            currentState = newState;
        }
    }
}
