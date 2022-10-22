using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [System.Serializable]
    public enum EnemyState
    {
        patrol,
        followPlayer,
        idle
    }

    //Parameter Patrol
    public float speedPatrol;
    public Vector2 startPatrolPos;
    public Vector2 endPatrolPos;

    //Parameter Follow Player
    public GameObject player;

    public EnemyState currentState;


    void Start()
    {
        currentState = EnemyState.patrol;
    }

    void Update()
    {
        switch (currentState)
        {
            case EnemyState.patrol:
                DoPatrol();
                break;
            case EnemyState.followPlayer:
                DoFollowPlayer();
                break;
            case EnemyState.idle:
                DoIdle();
                break;
        }
    }

    void DoPatrol()
    {
        if (transform.position.x < endPatrolPos.x)
        {
            transform.position = new Vector2(
                transform.position.x + speedPatrol * Time.deltaTime,
                transform.position.y
            );
        }
    }

    void DoFollowPlayer()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            player.transform.position,
            speedPatrol * Time.deltaTime
        );
    }

    void DoIdle()
    {
    }

    void ChangeState(EnemyState newState)
    {
        currentState = newState;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ChangeState(EnemyState.followPlayer);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ChangeState(EnemyState.idle);
        }
    }

}



















