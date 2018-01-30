using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class Base : MonoBehaviour
    {

        public void OnSpawn()
        {
            Debug.Log("[RaceBehavior] OnSpawn");
        }

        public void OnStart()
        {
            Debug.Log("[RaceBehavior] OnStart");
        }

        public void OnGoal()
        {
            Debug.Log("[RaceBehavior] OnGoal");
        }

    }

}