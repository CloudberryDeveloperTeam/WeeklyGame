using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{

    private Player_Handler _playerHandler;
    
    public IdleState(string name, Player_Handler playerHandler) : base("Idle", playerHandler)
    {
        _playerHandler = playerHandler;
    }


    public override void Enter()
    {
        base.Enter();
        Debug.Log("Idle");
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (Input.GetAxis("Vertical") != 0 && Input.GetAxis("Horizontal") != 0)
        {
            _playerHandler.ChangeState(_playerHandler.moveState);
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
    }

    public override void Exit()
    {
        base.Exit();
    }
}
