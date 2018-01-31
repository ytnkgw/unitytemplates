using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class StartTrigger : MonoBehaviour
    {

        [SerializeField]
        private string m_CharacterObjName;

        private void OnTriggerExit(Collider other)
        {
            if (other.name == m_CharacterObjName)
            {
                MessageBroker.Default.Publish<RaceStart>(new RaceStart { Msg = "[StartTrigger]" });
            }
        }

    }

}