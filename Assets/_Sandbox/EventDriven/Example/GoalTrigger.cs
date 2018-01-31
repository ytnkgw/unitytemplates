using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class GoalTrigger : MonoBehaviour
    {

        [SerializeField]
        private string m_CharacterObjName;

        private void OnTriggerEnter(Collider other)
        {
            if (other.name == m_CharacterObjName)
            {
                MessageBroker.Default.Publish<RaceGoal>(new RaceGoal { Msg = "[GoalTrigger]", Obj = other.gameObject});
            }
        }

    }

}