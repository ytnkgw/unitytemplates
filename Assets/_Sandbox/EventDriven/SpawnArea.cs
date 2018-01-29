using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class SpawnArea : MonoBehaviour
    {
        public delegate void SpawnEvent();
        public SpawnEvent OnSpawn;

        [SerializeField]
        private GameObject m_CharacterPrefab;

        [SerializeField]
        private RaceBehaviour m_Interface;


        public void Spawn ()
        {
            GameObject character = Instantiate(m_CharacterPrefab, gameObject.transform);
            character.name = m_CharacterPrefab.name;

            m_Interface.OnSpawn();
            if (OnSpawn != null) OnSpawn();
        }

        private void Start()
        {
            Spawn();
        }

    }

}