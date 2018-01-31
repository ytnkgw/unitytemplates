using MyLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System.Linq;

namespace Template.DesignPatterns.EventDriven
{

    public class RaceManager : Singleton<RaceManager>
    {

        private List<RaceBehaviour> _raceBehaviours = new List<RaceBehaviour>();

        private void Start()
        {
            _raceBehaviours = gameObject.GetComponentsInChildren<RaceBehaviour>().ToList();
        }

        public void OnStart()
        {

            MessageBroker.Default.Publish<string>("OnStart from race manager");
            foreach (var c in _raceBehaviours)
            {
                c.OnStart();
            }
        }

        public void OnGoal()
        {
            MessageBroker.Default.Publish<string>("OnGoal from race manager");
        }

    }

}