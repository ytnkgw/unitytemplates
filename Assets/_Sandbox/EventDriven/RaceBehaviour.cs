﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class RaceBehaviour : MonoBehaviour
    {

        public virtual void OnSpawn()
        {
            Debug.Log("[RaceBehavior] OnSpawn");
        }

        public virtual void OnStart()
        {
            Debug.Log("[RaceBehavior] OnStart");
        }

        public virtual void OnGoal()
        {
            Debug.Log("[RaceBehavior] OnGoal");
        }

    }

}