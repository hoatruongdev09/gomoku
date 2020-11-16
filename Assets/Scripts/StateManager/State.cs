using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine {
    public abstract class State {
        public virtual void Enter () { }
        public virtual void Enter (object options) {
            Enter ();
        }
        public virtual void Update () { }
        public virtual void Exit () { }
        public virtual void Exit (object options) {
            Exit ();
        }
    }
}