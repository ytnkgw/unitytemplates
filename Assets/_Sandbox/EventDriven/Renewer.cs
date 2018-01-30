using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class Renewer : RaceBehaviour
    {

        public override void OnStart()
        {
            Debug.Log("[Renewer] OnStart");
        }

        // TODO : override this
        public override void OnGoal()
        {
            Debug.Log("[Renewer] OnGoal");
        }

    }

}