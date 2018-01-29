using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class StartArea : MonoBehaviour
    {
        public delegate void StartEvent();
        public StartEvent OnStart;

        [SerializeField]
        private string m_CharacterObjName;

        [SerializeField]
        private RaceBehaviour m_Interface;


        private void OnTriggerEnter(Collider other)
        {
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.name == m_CharacterObjName)
            {
                m_Interface.OnStart();
                if (OnStart != null) OnStart();
            }
        }

    }

}
