﻿/*
 * This example script is showing coding style in this project.
 * TIPS : this is the sign of why you write the code like below.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyLib
{

    public class Example : MonoBehaviour
    {
        /*
         * TIPS :: Use "m_" as a first expression of member valiables.
         * 1. It makes it clear the difference between member valiables and function valiables.
         * 2. It prevent time wasting activity; finding a name of valiables.
         */
        [SerializeField]
        private int m_SampleInt;


        private void Start()
        {

        }

        private void Update()
        {

        }

    }

}
