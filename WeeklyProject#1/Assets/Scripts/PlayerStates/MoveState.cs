using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{
    public float horizontal;
    public float vertical;
    private float moveSpeed;

    
    private Player_Handler _playerHandler;
    


    public MoveState(string name, Player_Handler playerHandler) : base("Move", playerHandler)
    {
        _playerHandler = playerHandler;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Move");

        moveSpeed = 3f;
        
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        if (_playerHandler._rigidbody2D.velocity.x == 0 && _playerHandler._rigidbody2D.velocity.y == 0)
        {
            _playerHandler.ChangeState(_playerHandler.idleState);
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        _playerHandler._rigidbody2D.velocity = new Vector2(horizontal,vertical) * moveSpeed;
        

    }

    public override void Exit()
    {
        base.Exit();
 
    }
}
