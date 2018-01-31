using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Template.DesignPatterns.EventDriven
{

    public abstract class RaceBehaviour : MonoBehaviour
    {

        private System.IDisposable _stream;

        private void OnEnable()
        {
            _stream = MessageBroker.Default.Receive<string>().Subscribe(OnStartEvent).AddTo(gameObject);
        }

        private void OnDisable()
        {
            _stream.Dispose();
        }

        public void OnStartEvent(string test)
        {
            Debug.Log(test);
            OnStart();
        }

        public virtual void OnSpawn()
        {
            Debug.Log("[RaceBehavior] OnSpawn");
        }

        public virtual void OnStart()
        {
            Debug.Log("[RaceBehavior] OnStart");
        }

        public virtual void OnGoal()
        {
            Debug.Log("[RaceBehavior] OnGoal");
        }

    }

}