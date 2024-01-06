/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState {
    void Enter();
    void Execute();
    void Exit();
}

public class IdleState : IState
{
    public void Enter() {

    }
    public void Execute() {
 
    }
    public void Exit() {

    }
}

public class ChaseState : IState
{
    public void Enter() {

    }
    public void Execute() {
 
    }
    public void Exit() {
        
    }
}

public class StateMachine 
{
    public AdvancedEnemyAI enemy;
    public IState currentState;

    public void StateMachine(AdvancedEnemyAI enemy) {
        this.enemy = enemy;

    }

    public void SetState(IState state) {
        if (currentState != null) {
            currentState.Exit();
        }

        currentState = state;
        currentState.Enter();
    }

    public void Execute(IState state) {
        if (currentState != null) {
            currentState.Execute();
        }
    }
}

public class AdvancedEnemyAI : MonoBehaviour
{
    public StateMachine StateMachine;

    private void Awake() {
        StateMachine = new StateMachine(this);
        StateMachine.SetState(new IdleState());
    }
    // Update is called once per frame
    void Update()
    {
        StateMachine.Execute();
        if (Input.GetKeyDown(KeyCode.Space)) {
            StateMachine.SetState(new ChaseState());
        }
    }
}
*/