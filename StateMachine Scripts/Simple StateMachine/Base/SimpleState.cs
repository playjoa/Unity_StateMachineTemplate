using UnityEngine;

namespace StateMachines.SimpleStateMachine.Base
{
    public abstract class SimpleState<TManager> where TManager : MonoBehaviour
    {
        public abstract void EnterState(TManager stateManager);
    }
}