using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class StartArea : MonoBehaviour
    {

        [SerializeField]
        private string m_CharacterObjName;

        private void OnTriggerEnter(Collider other)
        {
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.name == m_CharacterObjName)
            {
                RaceManager.Instance.OnStart();
            }
        }

    }

}
