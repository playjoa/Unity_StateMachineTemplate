using UnityEngine;

namespace StateMachines.MonoBehaviourStateMachine.Base
{
    public abstract class MonoBehaviourState<TManager> where TManager : MonoBehaviour
    {
        public abstract void EnterState(TManager stateManager);
        public virtual void Update(TManager stateManager) { }
        public virtual void OnCollisionEnter(TManager stateManager, Collision collision) { }
        public virtual void OnCollisionExit(TManager stateManager, Collision collision) { }
        public virtual void OnTriggerEnter(TManager stateManager, Collider collider) { }
        public virtual void OnTriggerExit(TManager stateManager, Collider collider) { }
    }
}