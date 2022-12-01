using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Handler : MonoBehaviour
{
    private State currentState;

    [HideInInspector]
    public MoveState moveState;
    [HideInInspector]
    public IdleState idleState;
    public Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        idleState = new IdleState("Idle", this);
        moveState = new MoveState("Move", this);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentState = GetInitialState();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        if (currentState != null)
        {
            currentState.Enter();
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        if (currentState != null)
        {
            currentState.UpdateLogic();
        }


    }

    private void FixedUpdate()
    {
        
        if (currentState != null)
        {
            currentState.UpdatePhysics();
        }
    }

    public void ChangeState(State _state)
    {
        currentState.Exit();

        currentState = _state;
        currentState.Enter();
    }

    //başlangıç statei ayarlama kısmı
    protected virtual State GetInitialState()
    {
        return idleState;
    }
}
