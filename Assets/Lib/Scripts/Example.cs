/*
 * This example script is showing coding style in this project.
 * TIPS : this is the sign of why you write the code like below.
 */

using UnityEngine;

namespace MyLib
{

    public class Example : MonoBehaviour
    {
        /*
         * TIPS : Order of listing valiables declaration.
         * delegate > constant > member valiables
         * 1. list from the things you don't use so much.
         */
        public delegate void ExampleEvent();
        public ExampleEvent OnStart;
        public ExampleEvent OnEnd;

        /*
         * TIPS : Use "static readonly" to constant value.
         * TIPS : Use capital letter t constant value.
         */
        private static readonly int MAX_INT = 10;

        /*
         * TIPS :: Use "_" as a first expression of private member valiables.
         * 1. It makes it clear the difference between member valiables and function valiables.
         * 2. It prevent time wasting activity; finding a name of valiables.
         */
        [SerializeField]
        private int _sampleInt;

        /*
         * TIPS :: Use small letter as a first expression of public properties.
         * 1. make difference clearer between properties and methods
         */
        public int sampleInt
        {
            get { return _sampleInt; }
        }

        /*
         * TIPS :: Draw a line "//-------------" before #region preprocessor
         * 1. It makes boderline clearer
         */
        // ---------------------------------------------
        #region MonoBehavior functions
        private void Start()
        {
            /*
             * TIPS :: Comment "FIXME" for the port which should be fixed later.
             */
            // FIXME :: I'm not neccesary here
            _sampleInt = MAX_INT + _sampleInt;

            if (OnStart != null) OnStart();
        }

        private void OnDestroy()
        {
            if (OnEnd != null) OnEnd();
        }
        #endregion

    }

}
