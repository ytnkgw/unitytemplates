using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class GoalArea : MonoBehaviour
    {

        public delegate void GoalEvent();
        public GoalEvent OnGoal;

        [SerializeField]
        private string m_CharacterObjName;

        [SerializeField]
        private RaceBehaviour m_Interface;


        private void OnTriggerEnter(Collider other)
        {
            if (other.name == m_CharacterObjName)
            {
                m_Interface.OnGoal();
                if (OnGoal != null) OnGoal();
            }
        }

    }

}