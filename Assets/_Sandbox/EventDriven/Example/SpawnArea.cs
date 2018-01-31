using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class SpawnArea : MonoBehaviour
    {
        [SerializeField]
        private GameObject m_CharacterPrefab;

        public void Spawn ()
        {
            GameObject character = Instantiate(m_CharacterPrefab, gameObject.transform);
            character.name = m_CharacterPrefab.name;
        }

        private void Start()
        {
            Spawn();
        }

    }

}