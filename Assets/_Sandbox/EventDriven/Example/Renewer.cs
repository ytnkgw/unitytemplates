using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class Renewer : RaceBehaviour
    {
        [SerializeField]
        private SpawnArea m_Spawn;

        protected override void OnStart(RaceStart arg)
        {
            Debug.Log("[Renewer] OnStart, msg : " + arg.Msg);
        }

        protected override void OnGoal(RaceGoal arg)
        {
            Destroy(arg.Obj);
            m_Spawn.Spawn();
        }

        protected override void OnDead(CharacterDead arg)
        {
            Debug.Log("[Renewer] OnDead, msg : " + arg.Msg);
        }

    }

}