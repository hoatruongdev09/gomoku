using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine {
    public class StateManager<T> {
        public T Manager { get; private set; }
        public Machine Machine { get; private set; }

        public StateManager (T manager) {
            Manager = manager;
            Machine = new Machine ();
        }
    }
}