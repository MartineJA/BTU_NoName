using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public enum EnemyState
    {
        IDLE,
        WALK,
        DEATH,
        ATTACK
    }

    private EnemyState enemyState;
    private EnemyState currentState;

    [SerializeField]
    private Animator animator;

    private bool playerDetected = false;

    private Transform targetPosition;


    // Start is called before the first frame update
    void Start()
    {
        TransitionToState(EnemyState.IDLE);
        targetPosition = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        OnStateUpdate();
    }

    void OnStateEnter() 
    { 
        switch (currentState) 
        
        {
            case EnemyState.IDLE:  
                break;
            case EnemyState.ATTACK:
                animator.SetBool("isAttacking", true);
                break;
                
            case EnemyState.DEATH:
                animator.SetBool("isDead", true);
                break;   
            case EnemyState.WALK:
                animator.SetBool("isWalking", true);
                break;
            default: break;

        }           
    }

    void OnStateUpdate()
    {
        switch (currentState)

        {
            case EnemyState.IDLE:
                if (playerDetected) { TransitionToState(EnemyState.WALK); }
                break;
            case EnemyState.ATTACK: break;
            case EnemyState.DEATH: break;
            case EnemyState.WALK:
                transform.position = Vector2.MoveTowards(transform.position, targetPosition.position, Time.deltaTime);


                if (!playerDetected) { TransitionToState(EnemyState.IDLE); }
                break;
            default: break;

        }

    }

    void OnStateExit()
    {
        switch (currentState)

        {
            case EnemyState.IDLE: break;
            case EnemyState.ATTACK:
                animator.SetBool("isAttacking", false); break;
            case EnemyState.DEATH: break;
            case EnemyState.WALK:
                animator.SetBool("isWalking", false);
                break;
            default: break;

        }

    }

    void TransitionToState(EnemyState nextState) 
    {
        OnStateExit();
        currentState = nextState;
        OnStateEnter();

    }

    void PlayerDetected()
    {
        Debug.Log("Joueur détécté");
        playerDetected = true;
    }

    void PlayerEscaped()
    {
        Debug.Log("Joueur s'est enfui");
        playerDetected = false;
    }
    
}
