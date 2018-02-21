using System;
using UnityEngine;

namespace MyLib
{
    /*
     * [Obsolete]
     * Use "Scripting Define Symbols" at Player Settings > Other Settings
     * This is way much better, I mean easy.
     * 
     * This class is to provide and store 
     * the information whether Debug mode or not.
     */
    [Obsolete("Use \"Scription Define Symbols\" at Player Settings > Other Settings.")]
    public class Debugger : Singleton<Debugger>
    {
        [SerializeField]
        private bool _isDebug;

        public static bool isDebug()
        {
            return Instance._isDebug;
        }

#if DEBUG // Define DEBUG on Scripting Define Symbols
        private void Start()
        {
            Debug.Log("Debug Mode.");
        }
#endif

    }
}