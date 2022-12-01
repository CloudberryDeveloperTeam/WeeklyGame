using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{

    public string name;
    protected Player_Handler _playerHandler;

    public State(string name, Player_Handler playerHandler)
    {
        this.name = name;
        this._playerHandler = playerHandler;
    }

    public virtual void Enter()
    {
        
    }

    public virtual void UpdateLogic()
    {
        
    }

    public virtual void UpdatePhysics()
    {
        
    }

    public virtual void Exit()
    {
        
    }

}
