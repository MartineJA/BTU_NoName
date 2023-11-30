using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerState
{ 
    IDLE,
    WALK,
    SPRINT
}


public class PlayerStateMachine : MonoBehaviour
{
    #region public

    #endregion

    #region Life Cycle


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    #region Main
    private void OnStateEnter()
    {
        switch (_currentstate)
        {
            case PlayerState.IDLE:
                break;
            case PlayerState.WALK:
                break;
            case PlayerState.SPRINT:
                break;
            default:
                break;
        }
    }


    #endregion

    #region private

    private PlayerState _currentstate;

    #endregion
}
