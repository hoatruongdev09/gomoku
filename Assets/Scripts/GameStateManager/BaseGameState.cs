using System.Collections;
using System.Collections.Generic;
using StateMachine;
using UnityEngine;
public class BaseGameState : State {
    protected StateManager<GameManager> StateManager { get; private set; }

    public BaseGameState (StateManager<GameManager> stateManager) {
        StateManager = stateManager;
    }
}