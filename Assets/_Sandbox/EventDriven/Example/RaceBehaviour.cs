using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Template.DesignPatterns.EventDriven
{

    public abstract class RaceBehaviour : MonoBehaviour
    {
        // ---------------
        #region Life cycle
        protected virtual void OnSpawn()
        {
            Debug.Log("[RaceBehavior] OnSpawn");
        }

        protected virtual void OnStart(RaceStart arg)
        {
            Debug.Log("[RaceBehavior] OnStart : msg : " + arg.Msg);
        }

        protected virtual void OnGoal(RaceGoal arg)
        {
            Debug.Log("[RaceBehavior] OnGoal : msg : " + arg.Msg);
        }

        protected virtual void OnDead(CharacterDead arg)
        {

        }
        #endregion


        private void OnEnable()
        {
            // Register receivers.
            MessageBroker.Default.Receive<RaceStart>().Subscribe(OnStart).AddTo(gameObject);
            MessageBroker.Default.Receive<RaceGoal>().Subscribe(OnGoal).AddTo(gameObject);
            MessageBroker.Default.Receive<CharacterDead>().Subscribe(OnDead).AddTo(gameObject);
        }

    }

    // ---------------
    #region Event Tyeps
    public class RaceStart
    {
        public string Msg { get; set; }
    }

    public class RaceGoal
    {
        public GameObject Obj { get; set; }
        public string Msg { get; set; }
    }

    public class CharacterDead
    {
        public string Msg { get; set; }
    }
    #endregion

}