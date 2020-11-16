using System.Collections;
using System.Collections.Generic;
using StateMachine;
using UnityEngine;
public class GameStateManager : StateManager<GameManager> {
    public BaseGameState GameInitState { get; private set; }

    public GameStateManager (GameManager manager) : base (manager) {
        GameInitState = new GameInitState (this);
    }
}