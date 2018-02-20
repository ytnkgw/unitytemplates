using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyLib
{
    public class Debugger : Singleton<Debugger>
    {
        [SerializeField]
        private bool _isDebug;

        public static bool isDebug()
        {
            return Instance._isDebug;
        }
        
    }
}