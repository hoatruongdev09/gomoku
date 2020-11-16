using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine {
    public class Machine {
        public State CurrentState { get; set; }

        public void Start (State startState, object options = null) {
            CurrentState = startState;
            CurrentState.Enter (options);
        }
        public void ChangeState (State nextState, object startOption = null, object exitOption = null) {
            CurrentState.Exit (exitOption);
            CurrentState = nextState;
            CurrentState.Enter (startOption);
        }
    }
}